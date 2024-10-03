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

        public frmReturnDVDs(frmMainMenu parent)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtMemID.Text.Equals(""))
            {
                //MemberID must be entered

                MessageBox.Show("Error no member id was supplied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemID.Clear();
                txtMemID.Focus();
                return;
            }

            //display UI
            else
            {
                dgCurrentlyRented.Rows.Add("103", "Interstellar", "Sci-Fi", "19-10-2023");
                dgCurrentlyRented.Rows.Add("903", "Titanic", "Romance", "19-9-2023");
                dgCurrentlyRented.Rows.Add("223", "Indiana Jones", "Action", "27-10-2023");
                grpReturnBox.Visible = true;
            }

            for (int i = 0; i < dgCurrentlyRented.RowCount; i++)
            {
                chkRentedItems.Items.Add(dgCurrentlyRented.Rows[i].Cells["CartDVDTitle"].Value.ToString());
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            int row = dgCurrentlyRented.CurrentCell.RowIndex;
            String Date = dgCurrentlyRented.Rows[row].Cells["DateRented"].Value.ToString();

            DateTime DateRented = DateTime.Parse(Date);

            int diffOfDays = (dateNow - DateRented).Days;

            //hardcoded rates value
            double rates = 5.5;
            double total = 0;

            //check overdue DVDs
            if (diffOfDays > 60)
            {
                //apply extra charges
                total += 50;
            }

            //calculate pay

            for (int i = 0; i < chkRentedItems.Items.Count; i++)
            {
                if (chkRentedItems.GetItemChecked(i))
                {
                    double costOfDVD = diffOfDays * rates;
                    total += costOfDVD;
                }

            }

            //display confirmation message

            MessageBox.Show("Your running total is: " + total.ToString() + " Euros");

            //Reset UI
            for (int i = 0; i < chkRentedItems.Items.Count; i++)
            {
                chkRentedItems.Items.RemoveAt(i);
            }
            dgCurrentlyRented.Rows.Clear();
            txtMemID.Clear();
            txtMemID.Focus();
            grpReturnBox.Visible = false;
        }
    }
}

