using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DVDRental
{
    public partial class frmRemoveMem : Form
    {
        frmMainMenu Parent;
        public frmRemoveMem(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;

            //if file not found (Members file), (RentedItems file) display error message and send to main menu
            DialogResult dialogResult = MessageBox.Show("Do you want to cancel all memberhsips with overdue DVDs?", "Cancel Memberships", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes) {
                dgMemCancelled.Rows.Add("John", "Doe", "123456789");
                dgMemCancelled.Rows.Add("Bart", "Wicha", "223456789");
                dgMemCancelled.Rows.Add("John", "Smith", "323456789");
                dgMemCancelled.Rows.Add("John", "Smith", "423456789");
                dgMemCancelled.Rows.Add("Kevin", "Murphy", "523456789");

                //if no members retrieved display error message
                dgMemCancelled.Visible = true;
                label1.Visible = true;
                
            }

            //if no members retrieved display error message
            else
            {
                MessageBox.Show("No memberships have been cancelled", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
        }

    }
}
