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
    public partial class frmYearlyRevenue : Form
    {

        frmMainMenu Parent;
        public frmYearlyRevenue(frmMainMenu parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            // return to main menu
            this.Close();
            Parent.Visible = true;
        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {

            //User selects year and query what values map to the year
            //test values
            String[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
            double[] revenue = { 1234, 432, 4323, 3222, 9484, 3243, 3213, 1231, 854, 9347, 1029, 2344 };
           
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
