using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDRental
{
    public partial class frmUpdateMem : Form
    {

        frmMainMenu Parent;
        public frmUpdateMem(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;

            //test values being for example input of john
            dgMembers.Rows.Add("101", "John", "Doe", "A", "123456789");
            dgMembers.Rows.Add("203", "John", "Murphy", "A", "323456789");
            dgMembers.Rows.Add("234", "John", "Smith", "A", "423456789");
            dgMembers.Rows.Add("201", "John", "O'Connel", "A", "623456789");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //user entered details must be entered and contain only letters
            if (txtEnterSName.Text.Equals("")) {
                MessageBox.Show("Please enter the surname of the member you are trying to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSName.Clear();
                txtEnterSName.Focus();
                return;
            }

            for (int i = 0; i < txtEnterSName.Text.Length; i++)
            {
                if (!Char.IsLetter(txtEnterSName.Text[i]))
                {
                    MessageBox.Show("Invalid details entered must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEnterSName.Clear();
                    txtEnterSName.Focus();
                    return;
                }
            }

            dgMembers.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //all fields entered
            if (txtFName.Text.Equals("") || txtSName.Text.Equals("") || txtPhoneNum.Text.Equals(""))
            {
                MessageBox.Show("Please enter all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txtFName.Text.Equals(""))
                {
                    txtFName.Focus();
                    return;
                }

                if (txtSName.Text.Equals(""))
                {
                    txtSName.Focus();
                    return;
                }

                if (txtPhoneNum.Text.Equals(""))
                {
                    txtPhoneNum.Focus();
                    return;
                }

            }

            //fname sname contain only letters and phone num.length == 9

            for (int i = 0; i < txtFName.Text.Length; i++)
            {
                if (!Char.IsLetter(txtFName.Text[i]))
                {
                    MessageBox.Show("Invalid first name must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFName.Clear();
                    txtFName.Focus();
                    return;
                }
            }

            for (int i = 0; i < txtSName.Text.Length; i++)
            {
                if (!Char.IsLetter(txtSName.Text[i]))
                {
                    MessageBox.Show("Invalid surname must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSName.Clear();
                    txtSName.Focus();
                    return;
                }
            }

            if (txtPhoneNum.Text.Length != 9)
            {
                MessageBox.Show("Invalid phone number must contain exactly 9 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Clear();
                txtPhoneNum.Focus();
                return;
            }

            //PhoneNum contains only digits

            int phoneNum;

            if (!int.TryParse(txtPhoneNum.Text, out phoneNum)){
                MessageBox.Show("Invalid phone number must contain only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Clear();
                txtPhoneNum.Focus();
                return;
            }

            //display confimration Message
            MessageBox.Show("Data has been updates", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Reset UI
            grpUpdateValues.Visible = false;
            dgMembers.Visible = false;
            txtEnterSName.Clear();
            txtEnterSName.Focus();
            txtFName.Clear();
            txtPhoneNum.Clear();
            txtSName.Clear();
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
        }

        private void dgMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dgMembers.CurrentCell.RowIndex;

            txtFName.Text = dgMembers.Rows[Row].Cells["FName"].Value.ToString();
            txtSName.Text = dgMembers.Rows[Row].Cells["SName"].Value.ToString();
            txtPhoneNum.Text = dgMembers.Rows[Row].Cells["PhoneNum"].Value.ToString();

            grpUpdateValues.Visible = true;
        }
    }
}
