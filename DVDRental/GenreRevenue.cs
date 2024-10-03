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
    public partial class frmGenreRevenue : Form
    {

        frmMainMenu Parent;

        public frmGenreRevenue(frmMainMenu parent)
        {
            InitializeComponent();
            Parent = parent;


            String[] Genres = { "Horror", "Comedy", "Rom-Com", "Romance", "Sci-Fi", "Fiction" };
            double[] revenue = { 1234, 5432, 4323, 3222, 9484, 3243 };

            chrtGenreRevenue.ChartAreas[0].AxisX.Interval = 1;

            for (int i = 0; i < Genres.Length; i++)
            {
                chrtGenreRevenue.Series["Series1"].Points.AddXY(Genres[i], revenue[i]);
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
