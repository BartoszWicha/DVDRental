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
            frmRemoveMem frmRemoveMem = new frmRemoveMem(this);
            frmRemoveMem.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMem frmUpdateMem = new frmUpdateMem(this);
            frmUpdateMem.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegMem frmRegMem = new frmRegMem(this);
            frmRegMem.Show();
        }

        private void addDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDVD frmAddDVD = new frmAddDVD(this);
            frmAddDVD.Show();
        }

        private void modifyDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModifyDVD frmModifyDVD = new frmModifyDVD(this);
            frmModifyDVD.Show();
        }

        private void removeDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveDVDs frmRemoveDVDs = new frmRemoveDVDs(this);
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
            frmModifyCateg frmModifyCateg = new frmModifyCateg(this);
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
            frmYearlyRevenue frmYearlyRevenue = new frmYearlyRevenue(this);
            frmYearlyRevenue.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenreRevenue frmGenreRevenue = new frmGenreRevenue(this);
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
                get { return Color.From; }
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
