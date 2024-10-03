using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDRental
{
    public partial class frmMemberAdd : Form
    {

        frmMainMenu Parent;

        public frmMemberAdd() {
            InitializeComponent();
        }
        public frmMemberAdd(frmMainMenu parent)
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

        private void frmRegMem_Load(object sender, EventArgs e)
        {
            txtMemID.Text = Member.generateNextID().ToString();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //all fields entered
           if (txtFName.Text.Equals("")) {
                MessageBox.Show("Please enter a first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
           }

           if (txtSName.Text.Equals("")) {
                MessageBox.Show("Please enter a surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
           }

           if (txtPhoneNum.Text.Equals("")) {
                MessageBox.Show("Please enter a phone mumber", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Focus();
                return;
           }

            for (int i = 0; i < txtFName.Text.Length; i++)
            {
                if (!Char.IsLetter(txtFName.Text[i]))
                {
                    MessageBox.Show("first name must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFName.Clear();
                    txtFName.Focus();
                    return;
                }
            }

            for (int i = 0; i < txtSName.Text.Length; i++)
            {
                if (!Char.IsLetter(txtSName.Text[i]) && txtSName.Text[i] != '\'')
                {
                    MessageBox.Show("surname must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSName.Clear();
                    txtSName.Focus();
                    return;
                }
            }

            String phoneRegex = "(^08[1-9]{1})[\\s]{1}[0-9]{3}[\\s]{1}[0-9]{4}";

            for (int i = 0; i < txtPhoneNum.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPhoneNum.Text[i]) && txtPhoneNum.Text[i] != ' ')
                {
                    MessageBox.Show("Phone Number must contain only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNum.Clear();
                    txtPhoneNum.Focus();
                    return;
                }
            }

            if (!Regex.IsMatch(txtPhoneNum.Text, phoneRegex))
            {
                MessageBox.Show("Invalid format for phone number. (valid format is: 08X XXX XXXX)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Clear();
                txtPhoneNum.Focus();
                return;
            }

            Member member = new Member(Convert.ToInt32(txtMemID.Text), txtFName.Text, txtSName.Text, txtPhoneNum.Text);
            member.addMember();

            //display conf message
            MessageBox.Show("Data has been Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtFName.Clear();
            txtPhoneNum.Clear();
            txtSName.Clear();
            txtFName.Focus();
            txtMemID.Text = Member.generateNextID().ToString();
        }
    }
}
