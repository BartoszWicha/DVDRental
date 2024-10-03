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
    public partial class frmDVDModify : Form{

        frmMainMenu Parent;
        DVD dvdToUpdate = new DVD();

        public frmDVDModify() { 
            InitializeComponent();
        }
        public frmDVDModify(frmMainMenu parent)
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

            Utility.fillComboBox(cmbCateg, DVDRental.Category.getCategories(), 0);
            Utility.fillComboBox(cmbGenre, DVDRental.Genre.getGenres(), 3);

            if (cmbGenre.Items.Count <= 0 || cmbCateg.Items.Count <= 0)
            {
                if (cmbGenre.Items.Count <= 0) { MessageBox.Show("No data was gathered from Genres table\n\n returning to main menu", "Data not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { MessageBox.Show("No data was gathered from Category table\n\n returning to main menu", "Data not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                this.Close();
                Parent.Visible = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("Please enter the title of the DVD you are searching for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Clear();
                txtTitle.Focus();
                dgMatchingDVDs.Rows.Clear();
                return;
            }

            else
            {
                dgMatchingDVDs.Rows.Clear();
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
                    txtTitle.Clear();
                }
            }
        }
        private void dgMatchingDVDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Category category = new Category();
            Genre genre = new Genre();

            dvdToUpdate.setDVDID(Convert.ToInt32(dgMatchingDVDs.Rows[dgMatchingDVDs.CurrentCell.RowIndex].Cells[0].Value));
            dvdToUpdate.getDVDByID();

            category.setCatCode(dvdToUpdate.getCatCode());
            category.getCategory();

            genre.setGenreID(Convert.ToInt32(dvdToUpdate.getGenreID()));
            genre.getGenreByID();

            txtTitleToUpdt.Text = dvdToUpdate.getTitle();
            cmbCateg.SelectedItem = category.getCatCode() + " - " + category.getDescription();
            cmbGenre.SelectedItem = genre.getGenreID().ToString().PadLeft(3, '0') + " - " + genre.getGenreName();

            grpDVDDetails.Visible = true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < txtTitleToUpdt.Text.Length; i++)
            {
                if (!Char.IsLetter(txtTitleToUpdt.Text[i]) && txtTitleToUpdt.Text[i] != ' ')
                {
                    MessageBox.Show("Invalid category title must contain only letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitleToUpdt.Clear();
                    txtTitleToUpdt.Focus();
                    dgMatchingDVDs.Rows.Clear();
                    return;
                }
            }

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
            dvdToUpdate.modifyDVD();

            MessageBox.Show("Data has been Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtTitle.Clear();
            txtTitleToUpdt.Clear();
            dgMatchingDVDs.Rows.Clear();
            grpDVDDetails.Visible = false;
            txtTitle.Focus();
        }

    }
}
