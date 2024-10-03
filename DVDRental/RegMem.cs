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
    public partial class frmRegMem : Form
    {

        frmMainMenu Parent;

        public frmRegMem() {
            InitializeComponent();
        }
        public frmRegMem(frmMainMenu parent)
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
            //all fields entered
           if (txtFName.Text.Equals("")) {
                MessageBox.Show("Please enter all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
           }

           if (txtSName.Text.Equals("")) {
                MessageBox.Show("Please enter all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
           }

           if (txtPhoneNum.Text.Equals("")) {
                MessageBox.Show("Please enter all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Focus();
                return;
           }

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

            if (txtPhoneNum.Text.Length != 9) {
                MessageBox.Show("Invalid phone number must contain exactly 9 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Clear();
                txtPhoneNum.Focus();
                return;
            }

            int phoneNum;

            if (!int.TryParse(txtPhoneNum.Text, out phoneNum))
            {
                MessageBox.Show("Invalid phone number must contain only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNum.Clear();
                txtPhoneNum.Focus();
                return;
            }

            Member member = new Member(Convert.ToInt32(txtMemID.Text), txtFName.Text, txtSName.Text, Convert.ToInt32(txtPhoneNum.Text));
            member.RegisterMember();

            //display conf message
            MessageBox.Show("Data has been Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtFName.Clear();
            txtPhoneNum.Clear();
            txtSName.Clear();
            txtFName.Focus();
            txtMemID.Text = Member.generateNextID().ToString();
        }

        private void frmRegMem_Load(object sender, EventArgs e)
        {
            try
            {
                txtMemID.Text = Member.generateNextID().ToString();    
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException orclException)
            {

                if (orclException.Message.Equals("ORA-00942: table or view does not exist"))
                {
                    MessageBox.Show("Members file not found please contact admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Unexpected error occured please contact admin \nError Message: " + orclException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
                Parent.Visible = true;
            }
        }

    }
}
