using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDRental
{
    public partial class frmMemberModify : Form
    {

        frmMainMenu Parent;
        Member currentMember = new Member();
        public frmMemberModify() {
            InitializeComponent();
        }
        public frmMemberModify(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }
        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
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

            //populate datagrid

            DataSet ds = Member.getMatchingMembers(txtEnterSName.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dgMembers.Rows.Clear();
                dgMembers.Visible = true;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dgMembers.Rows.Add(ds.Tables[0].Rows[i][0],
                        ds.Tables[0].Rows[i][1],
                        ds.Tables[0].Rows[i][2],
                        ds.Tables[0].Rows[i][3],
                        ds.Tables[0].Rows[i][4]);
                }
            }

            else
            {
                MessageBox.Show("No members matching \"" + txtEnterSName.Text.ToString() + "\" have been found", "Members Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnterSName.Focus();
            }

            txtEnterSName.Clear();
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

            String phoneRegex = "(^08[1-9]{1})[\\s]*[0-9]{3}[\\s]*[0-9]{4}";

            for (int i = 0; i < txtPhoneNum.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPhoneNum.Text[i]) && txtPhoneNum.Text[i] != ' ')
                {
                    MessageBox.Show("Invalid Phone Number must contain only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNum.Clear();
                    txtPhoneNum.Focus();
                    return;
                }
            }

            if (!Regex.IsMatch(txtPhoneNum.Text, phoneRegex))
            {
                MessageBox.Show("Invalid format for phone number valid format is: 08X XXX XXXX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Clear();
                txtPhoneNum.Focus();
                return;
            }

            currentMember.setFirstName(txtFName.Text);
            currentMember.setSurName(txtSName.Text);
            currentMember.setPhoneNum(txtPhoneNum.Text);
            currentMember.modifyMember();

            //display confimration Message
            MessageBox.Show("Data has been updates", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            dgMembers.Rows.Clear();
            grpUpdateValues.Visible = false;
            dgMembers.Visible = false;
            txtEnterSName.Clear();
            txtEnterSName.Focus();
            txtFName.Clear();
            txtPhoneNum.Clear();
            txtSName.Clear();
        }

        private void dgMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != dgMembers.Rows.Count-1) { 
                int Row = dgMembers.CurrentCell.RowIndex;
                currentMember.getSelectedMember(Convert.ToInt32(dgMembers.Rows[Row].Cells["ID"].Value));

                txtFName.Text = currentMember.getFirstName();
                txtSName.Text = currentMember.getSurName();
                txtPhoneNum.Text = currentMember.getPhoneNum();

                grpUpdateValues.Visible = true;
            }
        }
    }
}
