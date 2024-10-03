using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDRental
{
    public partial class frmReturnDVDs : Form
    {

        frmMainMenu Parent;
        Member member = new Member();
        Rental rental = new Rental();
        DVD dvd = new DVD();

        public frmReturnDVDs(frmMainMenu parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        public frmReturnDVDs() { 
            InitializeComponent();
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            //for every item in toReturn data grid
            //add id to array

            int[] dvds = new int[dgDVDToReturn.Rows.Count];
            decimal total = 0;

            for (int i = 0; i < dgDVDToReturn.Rows.Count; i++)
            {
                dvds[i] = Convert.ToInt32(dgDVDToReturn.Rows[i].Cells["ReturnID"].Value);
                total += Convert.ToDecimal(dgDVDToReturn.Rows[i].Cells["ReturnCost"].Value);

                dvd.setDVDID(dvds[i]);
                dvd.getDVDByID();
                dvd.setStatus('A');
                dvd.modifyDVD();
            }

            //check if all dvds were returned if yes set rental status to finalized

            if (dgCurrentlyRented.Rows.Count == 0)
            {
                rental.setStatus('F');
            }

            rental.updateRentalItems(dvds);
            rental.updateRentalStatus();

            //display message your total is...
            MessageBox.Show("Your Total is " + total, "Total Sum", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset ui
            dgCurrentlyRented.Rows.Clear();
            dgDVDToReturn.Rows.Clear();
            dgMembers.Rows.Clear();
            grpReturnBox.Visible = false;
            txtSName.Clear();
            txtSName.Focus();
        }

        private void dgCurrentlyRented_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //add item in toReturn dg and remove from currRented dg
                dgDVDToReturn.Rows.Add(dgCurrentlyRented.Rows[e.RowIndex].Cells["RentedID"].Value, dgCurrentlyRented.Rows[e.RowIndex].Cells["RentedDVDTitle"].Value,
                    Convert.ToDateTime(rental.getDateRented()).Date.ToString("dd-MMM-yy"), dgCurrentlyRented.Rows[e.RowIndex].Cells["RentedCost"].Value);

                dgCurrentlyRented.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            dgMembers.Rows.Clear();

            if (txtSName.Text.Equals(""))
            {
                //MemberID must be entered

                MessageBox.Show("Error no member Surname was supplied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Clear();
                txtSName.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                ds = Member.getMatchingMembers(txtSName.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dgMembers.Rows.Add(ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1], ds.Tables[0].Rows[i][2], ds.Tables[0].Rows[i][3]);
                    }
                }

                else
                {
                    MessageBox.Show("Error active members with a matching surname dont exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSName.Clear();
                    txtSName.Focus();
                    return;
                }
            }
        }

        private void dgMembers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //display ui
                dgCurrentlyRented.Rows.Clear();

               
                member.getSelectedMember(Convert.ToInt32(dgMembers.Rows[e.RowIndex].Cells[0].Value));

                rental.getMembersRental(member.getMemberID());
                grpReturnBox.Visible = true;

                //if yes display ui and populate data grid
                for (int i = 0; i < rental.getDVDIDs().Count; i++)
                {
                    dvd.setDVDID(rental.getDVDIDs()[i]);
                    dvd.getDVDByID();
                    dgCurrentlyRented.Rows.Add(dvd.getDVDID(), dvd.getTitle() , Convert.ToDateTime(rental.getDateRented()).ToString("dd/MM/yyyy"), rental.getCost()[i]).ToString("0.00");
                }
            }
        }

        private void dgDVDToReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgCurrentlyRented.Rows.Add(dgDVDToReturn.Rows[e.RowIndex].Cells["ReturnID"].Value, dgDVDToReturn.Rows[e.RowIndex].Cells["ReturnDVDTitle"].Value,
                    Convert.ToDateTime(rental.getDateRented()).Date.ToString("dd-MMM-yy"), dgDVDToReturn.Rows[e.RowIndex].Cells["ReturnCost"].Value);

                dgDVDToReturn.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

