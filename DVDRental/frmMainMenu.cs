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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            mnuNavigation.Renderer = new ToolStripProfessionalRenderer(new changeDefaultColors());
            Application.EnableVisualStyles();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberRemove frmRemoveMem = new frmMemberRemove(this);
            frmRemoveMem.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberModify frmUpdateMem = new frmMemberModify(this);
            frmUpdateMem.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberAdd frmRegMem = new frmMemberAdd(this);
            frmRegMem.Show();
        }

        private void addDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDAdd frmAddDVD = new frmDVDAdd(this);
            frmAddDVD.Show();
        }

        private void modifyDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDModify frmModifyDVD = new frmDVDModify(this);
            frmModifyDVD.Show();
        }

        private void removeDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDRemove frmRemoveDVDs = new frmDVDRemove(this);
            frmRemoveDVDs.Show();
        }

        private void createCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateCateg frmCreateCateg = new frmCreateCateg(this);
            frmCreateCateg.Show();
        }

        private void modifyCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategoryModify frmModifyCateg = new frmCategoryModify(this);
            frmModifyCateg.Show();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentDVD frmRentDVD = new frmRentDVD(this);
            frmRentDVD.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnDVDs frmReturnDVDs = new frmReturnDVDs(this);
            frmReturnDVDs.Show();
        }

        private void yearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueYearly frmYearlyRevenue = new frmRevenueYearly(this);
            frmYearlyRevenue.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueGenre frmGenreRevenue = new frmRevenueGenre(this);
            frmGenreRevenue.Show();
        }

        /*private void manageCategoriesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            manageCategoriesToolStripMenuItem.BackColor = Color.FromArgb(39, 55, 77);
        }*/
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new changeDefaultColors()) { }
        }

        private class changeDefaultColors : ProfessionalColorTable
        {
            public changeDefaultColors(){
                base.UseSystemColors = false;
            }
            public override Color MenuItemSelected{
                get { return Color.FromArgb(82, 109, 130); }
            }
            public override Color MenuItemSelectedGradientBegin{
                get { return Color.FromArgb(157, 178, 191); }
            }
            public override Color MenuItemSelectedGradientEnd{
                get { return Color.FromArgb(157, 178, 191); }
            }
            public override Color MenuItemBorder {
                get { return Color.White; }
            }
            public override Color MenuBorder { 
                get { return Color.FromArgb(157, 178, 191); } 
            }
            public override Color MenuItemPressedGradientBegin {
                get { return Color.FromArgb(157, 178, 191); }
            }
            public override Color MenuItemPressedGradientEnd {
                get { return Color.FromArgb(157, 178, 191); }
            }
        }
    }
}
