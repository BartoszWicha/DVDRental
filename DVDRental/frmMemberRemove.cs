using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DVDRental
{
    public partial class frmMemberRemove : Form
    {
        frmMainMenu Parent;

        Member member = new Member();

        public frmMemberRemove()
        {
            InitializeComponent();
        }
        public frmMemberRemove(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataSet ds = Member.getMatchingMembers(txtEnterSName.Text);

            if (txtEnterSName.Text.Equals(""))
            {
                MessageBox.Show("Please enter the surname of the member you are trying to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterSName.Clear();
                txtEnterSName.Focus();
                return;
            }

            //populate datagrid

            if (ds.Tables[0].Rows.Count > 0)
            {
                dgMembers.Rows.Clear();
                dgMembers.Visible = true;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dgMembers.Rows.Add(ds.Tables[0].Rows[i][0],
                        ds.Tables[0].Rows[i][1],
                        ds.Tables[0].Rows[i][2],
                        ds.Tables[0].Rows[i][3],
                        ds.Tables[0].Rows[i][4]);
                }
            }

            else
            {
                MessageBox.Show("No members matching \"" + txtEnterSName.Text.ToString() + "\" have been found", "Members Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnterSName.Focus();
            }
        }

        private void dgMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != dgMembers.Rows.Count - 1)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to cancel all memberhsips with overdue DVDs?", "Cancel Memberships", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    int Row = dgMembers.CurrentCell.RowIndex;
                    member.getSelectedMember(Convert.ToInt32(dgMembers.Rows[Row].Cells["ID"].Value));

                    if (!member.memberHasUnreturnedRentals())
                    {
                        member.cancelMember();
                        String memeberName = member.getFirstName() + " " + member.getSurName();
                        MessageBox.Show("Member \"" + memeberName + "\" has been succesfully canceled", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Couldnt cancel! Member has unreturned DVDs", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("Action was cancelled", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    Parent.Visible = true;
                }
            }
        }
    }
}
