using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DVDRental
{
    public partial class frmDVDAdd : Form
    {

        frmMainMenu Parent;

        public frmDVDAdd()
        {
            InitializeComponent();
        }
        public frmDVDAdd(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }
        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
        private void frmAddDVD_Load(object sender, EventArgs e)
        {

            cmbCateg.Items.Clear();
            Utility.fillComboBox(cmbCateg, Category.getCategories(), 0);

            cmbGenres.Items.Clear();
            Utility.fillComboBox(cmbGenres, Genre.getGenres(), 3);

            txtID.Text = DVD.generateNextDVDID().ToString();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //validate data
            if (txtTitle.Text.Equals("")) {
                MessageBox.Show("Please enter the title of the DVD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }
            if (cmbCateg.Text.Equals("")) {
                MessageBox.Show("Please select a Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCateg.Focus();
                return;
            }
            if (cmbGenres.Text.Equals("")) {
                MessageBox.Show("Please select a Genre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGenres.Focus();
                return;
            }

            if (!txtTitle.Text.All(character => char.IsWhiteSpace(character) || char.IsLetterOrDigit(character))) {
                MessageBox.Show("Title must consist of only letters and digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            for (int i = 0; i < txtTitle.Text.Length; i++)
            {
                if (!Char.IsLetter(txtTitle.Text[i]) && txtTitle.Text[i] != ' ')
                {
                    MessageBox.Show("Invalid title must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitle.Clear();
                    txtTitle.Focus();
                    return;
                }
            }

            DVD dvd = new DVD(Convert.ToInt32(txtID.Text), txtTitle.Text, Convert.ToChar("A"), cmbCateg.Text.Substring(0, 2).ToUpper(), Convert.ToInt32(cmbGenres.Text.Substring(0, 4)));
            dvd.addDVD();

            MessageBox.Show("Data has been Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtTitle.Clear();
            txtTitle.Focus();
            cmbGenres.Items.Clear();
            cmbCateg.Items.Clear();
            Utility.fillComboBox(cmbCateg, Category.getCategories(), 0);
            Utility.fillComboBox(cmbGenres, Genre.getGenres(), 3);
            txtID.Text = DVD.generateNextDVDID().ToString();

        }
        
    }
}
