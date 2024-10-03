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
        public frmRentDVD(frmMainMenu parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //DVDTitle must be entered

            if (txtDVDTitle.Text.Equals(""))
            {
                MessageBox.Show("Error no DVD Title was entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVDTitle.Clear();
                txtDVDTitle.Focus();
                return;
            }

            else {

                dgSimilarDVDs.Visible = true;
                //test hard coded values
                if (txtDVDTitle.Text.Equals("DvD1")) { 
                    dgSimilarDVDs.Rows.Clear();
                    dgSimilarDVDs.Rows.Add("103", "Interstellar", "Sci-Fi");
                    dgSimilarDVDs.Rows.Add("107", "Movie2", "Horror");
                    dgSimilarDVDs.Rows.Add("320", "Movie3", "Thriller");
                }

                if (!txtDVDTitle.Text.Equals("") && !txtDVDTitle.Text.Equals("DvD1")) {
                    dgSimilarDVDs.Rows.Clear();
                    dgSimilarDVDs.Rows.Add("903", "Titanic", "Romance");
                    dgSimilarDVDs.Rows.Add("853", "Movie4", "Comedy");
                    dgSimilarDVDs.Rows.Add("123", "Movie5", "Rom-Com");
                }
            }


        }

        private void btnConclude_Click(object sender, EventArgs e)
        {
            //display confirmation message
            MessageBox.Show("Rent has been complete", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpSearchDVDs.Visible = false;
            txtDVDTitle.Clear();
            txtMemID.Clear();
            dgCart.Rows.Clear();
            dgSimilarDVDs.Rows.Clear();
            txtMemID.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //MemberID must be entered
            if (txtMemID.Text.Equals(""))
            {
                MessageBox.Show("Error no member id was supplied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemID.Clear();
                txtMemID.Focus();
                return;
            }

            else
            {
                grpSearchDVDs.Visible = true;
            }
        }

        private void dgSimilarDVDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if cart has at most 3 items

            if (dgCart.RowCount < 3)
            {
                int row = dgSimilarDVDs.CurrentCell.RowIndex;
                String ID = dgSimilarDVDs.Rows[row].Cells["ID"].Value.ToString();
                String DVDTitle = dgSimilarDVDs.Rows[row].Cells["DVDTitle"].Value.ToString();
                String Genre = dgSimilarDVDs.Rows[row].Cells["Genre"].Value.ToString();

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
                dgCart.Rows.Add(ID, DVDTitle, Genre);

            }

            else
            {
                MessageBox.Show("Cart is full please remove an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgCart.CurrentCell.RowIndex;

            dgCart.Rows.RemoveAt(row);
        }
    }
}
