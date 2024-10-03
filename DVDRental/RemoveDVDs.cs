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
    public partial class frmRemoveDVDs : Form
    {

        frmMainMenu Parent;

        public frmRemoveDVDs()
        {
            InitializeComponent();
        }

        public frmRemoveDVDs(frmMainMenu parent)
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
                    MessageBox.Show("No DVDs matching \"" + txtTitle.Text.ToString() + "\" have been found", "No DVDs Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DialogResult choice = MessageBox.Show("Are you sure you want to set " + dgMatchingDVDs.Rows[dgMatchingDVDs.CurrentCell.RowIndex].Cells[1].Value.ToString() + " As unavailable?", "Warning",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                DVD.removeDVD(DVDID);

                MessageBox.Show("DVD has been removed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else{
                MessageBox.Show("Process has been canceled", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        
    }
}
