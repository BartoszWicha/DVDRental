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
    public partial class frmModifyCateg : Form
    {

        frmMainMenu Parent;
        Category currentCategory = new Category();

        public frmModifyCateg() 
        { 
            InitializeComponent();
        }

        public frmModifyCateg(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
            Utility.fillComboBox(cmbCatCode, "Categories", 0);
        }

        private void mainMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void cmbCatCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatCode.Text != "")
            {
                String catCode = cmbCatCode.Text.Substring(0, 2);

                currentCategory.getSelectedCategory(catCode);

                txtDesc.Text = currentCategory.getDescription();
                txtRates.Text = currentCategory.getRate().ToString("0.00");

                grpDetails.Visible = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //validate data
            if (txtRates.Text.Equals(""))
            {
                MessageBox.Show("Please enter a value for rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Focus();
                return;
            }

            if (txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Please enter a description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            double rate;
            bool valid = Double.TryParse(txtRates.Text, out rate);

            if(!valid)
            {
                MessageBox.Show("Invalid! Please re-enter a valid rate for the category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Clear();
                txtRates.Focus();
                return;
            }

            if (rate < 0)
            {
                MessageBox.Show("Invalid! Rate must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Text = "0.00";
                txtRates.Focus();
                return;
            }

            for (int i = 0; i < txtDesc.Text.Length; i++)
            {
                if (!Char.IsLetter(txtDesc.Text[i]))
                {
                    MessageBox.Show("Invalid category title must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesc.Clear();
                    txtDesc.Focus();
                    return;
                }
            }

            try {
                //update data in db
                currentCategory.setDescription(txtDesc.Text);
                currentCategory.setRate(Convert.ToDecimal(txtRates.Text));
                currentCategory.modifyCategory();

                //display message
                MessageBox.Show("Data has been updated", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Oracle.ManagedDataAccess.Client.OracleException orclException)
            {

                if (orclException.Message.Equals("ORA-00942: table or view does not exist"))
                {
                    MessageBox.Show("Category file not found contact admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unexpected error occured please contact admin \nError Message: " + orclException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
                Parent.Visible = true;
            }
            
            //reset ui
            txtDesc.Clear();
            txtRates.Clear();
            grpDetails.Visible = false;
            cmbCatCode.SelectedIndex = -1;
            cmbCatCode.Items.Clear();
            Utility.fillComboBox(cmbCatCode, "Categories", 0);

        }

    }
}
