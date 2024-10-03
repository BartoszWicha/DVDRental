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
    public partial class frmRevenueGenre : Form
    {

        frmMainMenu Parent;

        public frmRevenueGenre(frmMainMenu parent)
        {
            InitializeComponent();
            Parent = parent;

            //on load
            DataSet ds = new DataSet();
            ds = Rental.getRevenueGroupedByGenre();

            chrtGenreRevenue.ChartAreas[0].AxisX.Interval = 1;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                chrtGenreRevenue.Series["Series1"].Points.AddXY(ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1]);
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
