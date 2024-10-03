using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DVDRental
{
    public partial class frmRevenueYearly : Form
    {

        frmMainMenu Parent;
        public frmRevenueYearly(frmMainMenu parent)
        {
            InitializeComponent();
            Parent = parent;

            cmbYears = Rental.fillCmbYears(cmbYears);
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {

            chrtYearly.Series.Clear();
            chrtYearly.Series.Add("Series1");

            //User selects year and query what values map to the year
            //test values
            DataSet ds = Rental.getRevenueOfYear(Int32.Parse(this.cmbYears.Text));

            String[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            decimal[] revenue = new decimal[months.Length];

            for (int i = 0; i < ds.Tables[0].Columns.Count; i++) {

                revenue[Int32.Parse(ds.Tables[0].Rows[i][0].ToString())-1] = Int32.Parse(ds.Tables[0].Rows[i][1].ToString());

            }

            //Display UI
            chrtYearly.Visible = true;
            lbEuro.Visible = true;
            lbMonths.Visible = true;
            chrtYearly.ChartAreas[0].AxisX.Interval = 1;


            //modify chart depending on months values
            for (int i = 0; i < months.Length; i++)
            {
                chrtYearly.Series["Series1"].Points.AddXY(months[i], revenue[i]);
            }

        }

    }
}
