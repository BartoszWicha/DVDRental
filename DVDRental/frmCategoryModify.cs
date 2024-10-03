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
    public partial class frmCategoryModify : Form
    {

        frmMainMenu Parent;
        Category category = new Category();

        public frmCategoryModify() 
        { 
            InitializeComponent();
        }
        public frmCategoryModify(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
            Utility.fillComboBox(cmbCatCode, Category.getCategories(), 0);
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
                category.setCatCode(cmbCatCode.Text.Substring(0, 2));
                category.getCategory();

                txtDesc.Text = category.getDescription();
                txtRates.Text = category.getRate().ToString("0.00");

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

            if (txtDesc.Text.Length > 30)
            {
                MessageBox.Show("Description Cannot contain more than 30 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Clear();
                txtDesc.Focus();
                return;
            }

            String regex = "[0-9]?[0-9]?(\\.[0-9][0-9]?)?";

            if (!Regex.IsMatch(txtRates.Text, regex)) {
                MessageBox.Show("Invalid! Rate Format is invalid. Please use 00.00 format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Clear();
                txtRates.Focus();
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

            if (rate <= 0)
            {
                MessageBox.Show("Invalid! Rate must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Text = "0.00";
                txtRates.Focus();
                return;
            }

            for (int i = 0; i < txtDesc.Text.Length; i++)
            {
                if (!Char.IsLetter(txtDesc.Text[i]) && txtDesc.Text[i] != ' ')
                {
                    MessageBox.Show("Invalid category title must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesc.Clear();
                    txtDesc.Focus();
                    return;
                }
            }

            category.setDescription(txtDesc.Text);
            category.setRate(Convert.ToDecimal(txtRates.Text));
            category.modifyCategory();

            //display message
            MessageBox.Show("Data has been updated", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset ui
            txtDesc.Clear();
            txtRates.Clear();
            grpDetails.Visible = false;
            cmbCatCode.SelectedIndex = -1;
            cmbCatCode.Items.Clear();
            Utility.fillComboBox(cmbCatCode, Category.getCategories(), 0);

        }

    }
}
