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
    public partial class frmRentDVD : Form
    {

        frmMainMenu Parent;
        Member currentMember = new Member();
        DVD dvd = new DVD();
        Rental rental = new Rental();

        public frmRentDVD() { 
            InitializeComponent();
        }
        public frmRentDVD(frmMainMenu parent)
        {
            InitializeComponent();
            Parent = parent;
        }
        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            dgMembers.Rows.Clear();

            //MemberID must be entered
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Error no surname was entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Clear();
                txtSurname.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                ds = Member.getMatchingMembers(txtSurname.Text);
                if (!Utility.checkIfDataSetEmpty(ds))
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dgMembers.Rows.Add(ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1], ds.Tables[0].Rows[i][2], ds.Tables[0].Rows[i][3]);
                    }
                }

                else
                {
                    MessageBox.Show("Error active members with a matching surname dont exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Clear();
                    txtSurname.Focus();
                    return;
                }
            }
        }
        private void dgMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentMember.getSelectedMember(Convert.ToInt32(dgMembers.Rows[e.RowIndex].Cells[0].Value));

                //check if member has unreturned dvds
                DataSet ds = new DataSet();
                Boolean dvdsDue = currentMember.memberHasUnreturnedRentals();

                if (dvdsDue)
                {
                    MessageBox.Show("Member has DVDs due to return before renting more", "DVDs Due", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    grpSearchDVDs.Visible = true;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            //DVDTitle must be entered

            if (txtDVDTitle.Text.Equals(""))
            {
                MessageBox.Show("Error no DVD Title was entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVDTitle.Clear();
                txtDVDTitle.Focus();
                dgSimilarDVDs.Rows.Clear();
                return;
            }

            else {
                dgSimilarDVDs.Rows.Clear();

                DataSet ds = new DataSet();
                ds = DVD.getMatchingDVDs(txtDVDTitle.Text);

                if (ds.Tables[0].Rows.Count > 0) {

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {

                        dgSimilarDVDs.Rows.Add(ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1], ds.Tables[0].Rows[i][3], ds.Tables[0].Rows[i][4]);

                    }
                }

                else {
                    MessageBox.Show("No Matching DVDs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDVDTitle.Clear();
                    txtDVDTitle.Focus();
                    return;
                }
            }
        }
        private void btnConclude_Click(object sender, EventArgs e)
        {
            if (dgCart.Rows.Count > 0)
            {
                rental.setRentID(Rental.generateNextRentID());
                rental.setMemberID(currentMember.getMemberID());

                DVD dvd = new DVD();
                int[] dvdIDs = new int[dgCart.Rows.Count];

                for (int i = 0; i < dgCart.Rows.Count; i++)
                {
                    dvd.setDVDID(Convert.ToInt32(dgCart.Rows[i].Cells["CartID"].Value));
                    dvd.getDVDByID();
                    dvd.setStatus('R');
                    
                    dvdIDs[i] = dvd.getDVDID();
                    rental.setDVDIDs(dvdIDs);

                    dvd.modifyDVD();
                }

                rental.saveRental();

                //display confirmation message
                MessageBox.Show("Rent has been complete", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                grpSearchDVDs.Visible = false;
                txtDVDTitle.Clear();
                txtSurname.Clear();
                dgCart.Rows.Clear();
                dgSimilarDVDs.Rows.Clear();
                txtSurname.Focus();
            }

            else {
                MessageBox.Show("No items in cart", "No Data Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
        private void dgSimilarDVDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //check if cart has at most 3 items
                if (dgCart.RowCount < 3)
                {
                    String ID = dgSimilarDVDs.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    String DVDTitle = dgSimilarDVDs.Rows[e.RowIndex].Cells["DVDTitle"].Value.ToString();
                    String Categories = dgSimilarDVDs.Rows[e.RowIndex].Cells["Categories"].Value.ToString();
                    String Genre = dgSimilarDVDs.Rows[e.RowIndex].Cells["Genre"].Value.ToString();

                    for (int i = 0; i < dgCart.RowCount; i++)
                    {

                        //check for items already in cart
                        if (ID.Equals(dgCart.Rows[i].Cells["CartID"].Value.ToString()))
                        {
                            MessageBox.Show("Items already in cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    //add data to cart
                    dgCart.Rows.Add(ID, DVDTitle, Categories, Genre);
                }

                else
                {
                    MessageBox.Show("Cart is full please remove an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgCart.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
