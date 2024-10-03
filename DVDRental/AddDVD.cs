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
    public partial class frmAddDVD : Form
    {

        frmMainMenu Parent;

        public frmAddDVD()
        {
            InitializeComponent();
        }

        public frmAddDVD(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
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

            if (Utility.checkUnique("DVDs", "LOWER(title)", "'" + txtTitle.Text.ToLower().ToString() + "'")) {
                MessageBox.Show("DVD with that title already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            DVD dvd = new DVD(Convert.ToInt32(txtID.Text), txtTitle.Text, Convert.ToChar("A"), cmbCateg.Text.Substring(0, 2).ToUpper(), Convert.ToInt32(cmbGenres.Text.Substring(0, 4)));

            dvd.addDVD();

            //Display Confirmation Message
            MessageBox.Show("Data has been Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtTitle.Clear();
            txtTitle.Focus();
            cmbGenres.Items.Clear();
            cmbCateg.Items.Clear();
            Utility.fillComboBox(cmbCateg, "Categories", 0);
            Utility.fillComboBox(cmbGenres, "Genres", 3);
            txtID.Text = DVD.generateNextDVDID().ToString();

        }

        //validating if file exists
        String pointOfFailure = "";

        private void frmAddDVD_Load(object sender, EventArgs e)
        {
            try {
                pointOfFailure = "Categories";
                cmbCateg.Items.Clear();
                Utility.fillComboBox(cmbCateg, "Categories", 0);

                pointOfFailure = "Genres";
                cmbGenres.Items.Clear();
                Utility.fillComboBox(cmbGenres, "Genres", 3);

                pointOfFailure = "DVDs";
                txtID.Text = DVD.generateNextDVDID().ToString();


            }
            catch (Oracle.ManagedDataAccess.Client.OracleException orclException)
            {

                if (orclException.Message.Equals("ORA-00942: table or view does not exist"))
                {
                    MessageBox.Show(pointOfFailure + " file not found please contact admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
