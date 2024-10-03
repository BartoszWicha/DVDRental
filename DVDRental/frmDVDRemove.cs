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
    public partial class frmDVDRemove : Form
    {

        frmMainMenu Parent;
        DVD dvd = new DVD();

        public frmDVDRemove()
        {
            InitializeComponent();
        }
        public frmDVDRemove(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }
        private void mnuMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
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
                MessageBox.Show("No DVDs matching \"" + txtTitle.Text.ToString() + "\" have been found", "No DVDs Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Focus();
                txtTitle.Clear();
            }

        }
        private void dgMatchingDVDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int DVDID = Convert.ToInt32(dgMatchingDVDs.Rows[dgMatchingDVDs.CurrentCell.RowIndex].Cells[0].Value);

            DialogResult choice = MessageBox.Show("Are you sure you want to remove" + dgMatchingDVDs.Rows[dgMatchingDVDs.CurrentCell.RowIndex].Cells[1].Value.ToString() + ". DVD will no longer be available", "Warning",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {

                dvd.setDVDID(DVDID);
                dvd.removeDVD();

                MessageBox.Show("DVD has been removed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reload data grid
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
            }

            else{
                MessageBox.Show("Process has been canceled", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
