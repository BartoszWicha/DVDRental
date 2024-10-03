using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDRental
{
    public partial class frmCreateCateg : Form
    {

        frmMainMenu Parent;

        public frmCreateCateg() 
        { 
            InitializeComponent();
        }
        public frmCreateCateg(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }
        public void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtCatCode.Text.Equals("")) {
                MessageBox.Show("Please enter a category code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatCode.Focus();
                return;
            }
            if (txtRates.Text.Equals("")) {
                MessageBox.Show("Please enter a value for rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Focus();
                return;
            }
            if (txtDesc.Text.Equals("")) {
                MessageBox.Show("Please enter a description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            if (txtCatCode.Text.Length != 2) {
                MessageBox.Show("Category Code entered is invalid must be exactly 2 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatCode.Clear();
                txtCatCode.Focus();
                return;
            }

            if(txtDesc.Text.Length > 30) {
                MessageBox.Show("Description Cannot contain more than 30 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Clear();
                txtDesc.Focus();
                return;
            }

            String regex = "[0-9]?[0-9]?(\\.[0-9][0-9]?)?";

            if (!Regex.IsMatch(txtRates.Text, regex))
            {
                MessageBox.Show("Rate Format is invalid. Please use 00.00 format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Clear();
                txtRates.Focus();
                return;
            }

            double rate;
            bool valid = Double.TryParse(txtRates.Text, out rate);

            if (valid)
            {
                if (rate <= 0)
                {
                    MessageBox.Show("Rate must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRates.Text = "0.00";
                    txtRates.Focus();
                    return;
                }
            }

            else 
            {
                MessageBox.Show("Please re-enter a valid rate for the category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRates.Clear();
                txtRates.Focus();
                return;
            }

            for (int i = 0; i < txtDesc.Text.Length; i++) {
                if (!Char.IsLetter(txtDesc.Text[i]) && txtDesc.Text[i] != ' ') {
                    MessageBox.Show("Invalid category title must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesc.Clear();
                    txtDesc.Focus();
                    return;
                }
            }

 
            if (Category.catCodeIsUnique(txtCatCode.Text.ToString().ToUpper()))
            {
                MessageBox.Show("A category with this category code already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatCode.Clear();
                txtCatCode.Focus();
                return;
            }

            Category category = new Category(txtCatCode.Text.ToUpper(), txtDesc.Text, Convert.ToDecimal(txtRates.Text));
            category.createCategory();

            MessageBox.Show("Data has been saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            txtCatCode.Clear();
            txtDesc.Clear();
            txtRates.Text = "0.00";
            txtCatCode.Focus();
        }

    }
}
