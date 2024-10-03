using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DVDRental
{
    public partial class frmModifyDVD : Form{

        frmMainMenu Parent;
        DVD dvdToUpdate = new DVD();

        public frmModifyDVD() { 
            InitializeComponent();
        }

        public frmModifyDVD(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
        private void frmModifyDVD_Load(object sender, EventArgs e)
        {
            String pointOfFailure = "Categories";

            try
            {
                Utility.fillComboBox(cmbCateg, "Categories", 0);

                pointOfFailure = "Genres";
                Utility.fillComboBox(cmbGenre, "Genres", 3);
            }

            catch (Oracle.ManagedDataAccess.Client.OracleException orclException)
            {

                if (orclException.Message.Equals("ORA-00942: table or view does not exist"))
                {
                    MessageBox.Show(pointOfFailure + " file not found contact admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unexpected error occured please contact admin \nError Message: " + orclException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
                Parent.Visible = true;
            }

            /*if (cmbGenre.Items.Count <= 0 || cmbCateg.Items.Count <= 0)
            {
                if (cmbGenre.Items.Count <= 0) { MessageBox.Show("No data was gathered from Genres table\n\n returning to main menu", "Data not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { MessageBox.Show("No data was gathered from Category table\n\n returning to main menu", "Data not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                this.Close();
                Parent.Visible = true;
            }*/
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtTitleToUpdt.Text.Equals(""))
            {
                MessageBox.Show("Please enter the title of the DVD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitleToUpdt.Focus();
                return;
            }
            if (cmbCateg.Text.Equals(""))
            {
                MessageBox.Show("Please select a Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCateg.Focus();
                return;
            }
            if (cmbGenre.Text.Equals(""))
            {
                MessageBox.Show("Please select a Genre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGenre.Focus();
                return;
            }

            if (!txtTitleToUpdt.Text.All(character => char.IsWhiteSpace(character) || char.IsLetterOrDigit(character)))
            {
                MessageBox.Show("Title must consist of only letters and digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            dvdToUpdate.setDVDTitle(txtTitleToUpdt.Text);
            dvdToUpdate.setGenreID(Convert.ToInt32(cmbGenre.Text.Substring(0, 3)));
            dvdToUpdate.setcatCode(cmbCateg.Text.Substring(0, 2));

            
            dvdToUpdate.updateDVD();

            //Display Confirmation Message
            MessageBox.Show("Data has been Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            //Reset UI
            txtTitle.Clear();
            txtTitleToUpdt.Clear();
            dgMatchingDVDs.Rows.Clear();
            grpDVDDetails.Visible = false;
            txtTitle.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgMatchingDVDs.Rows.Clear();

            try
            {
                DataSet ds = DVD.getMatchingDVDs(txtTitle.Text);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dgMatchingDVDs.Rows.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4, '0'),
                            ds.Tables[0].Rows[i][1],
                            ds.Tables[0].Rows[i][2],
                            ds.Tables[0].Rows[i][3],
                            ds.Tables[0].Rows[i][4]);
                    }
                }

                else
                {
                    MessageBox.Show("No available DVDs matching \"" + txtTitle.Text.ToString() + "\" have been found", "No DVDs Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitle.Focus();
                }

                txtTitle.Clear();
            }

            catch (Oracle.ManagedDataAccess.Client.OracleException orclException)
            {

                if (orclException.Message.Equals("ORA-00942: file or view does not exist"))
                {
                    MessageBox.Show("DVDs file not found please contact admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unexpected error occured please contact admin \nError Message: " + orclException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
                Parent.Visible = true;
            }

        }
        private void dgMatchingDVDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int DVDID = Convert.ToInt32(dgMatchingDVDs.Rows[dgMatchingDVDs.CurrentCell.RowIndex].Cells[0].Value);
            Category selectedCategory = new Category();
            Genre selectedGenre = new Genre();

            dvdToUpdate.getDVDByID(DVDID);
            selectedCategory.getSelectedCategory(dvdToUpdate.getCatCode().ToString());
            selectedGenre.getSelectedGenre(dvdToUpdate.getGenreID().ToString());

            txtTitleToUpdt.Text = dvdToUpdate.getTitle();
            cmbCateg.SelectedItem = selectedCategory.getCatCode() + " - " + selectedCategory.getDescription();
            cmbGenre.SelectedItem = selectedGenre.getGenreID().ToString().PadLeft(3, '0') + " - " + selectedGenre.getGenreName();

            grpDVDDetails.Visible = true;
        }
  
    }
}
