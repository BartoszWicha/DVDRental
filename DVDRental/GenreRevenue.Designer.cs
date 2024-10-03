namespace DVDRental
{
    partial class frmGenreRevenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.chrtGenreRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.mnuNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGenreRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClick});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(800, 24);
            this.mnuNavigation.TabIndex = 30;
            this.mnuNavigation.Text = "menuStrip1";
            // 
            // mnuBackClick
            // 
            this.mnuBackClick.Name = "mnuBackClick";
            this.mnuBackClick.Size = new System.Drawing.Size(80, 20);
            this.mnuBackClick.Text = "Main Menu";
            this.mnuBackClick.Click += new System.EventHandler(this.mnuBackClick_Click);
            // 
            // chrtGenreRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtGenreRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtGenreRevenue.Legends.Add(legend2);
            this.chrtGenreRevenue.Location = new System.Drawing.Point(77, 55);
            this.chrtGenreRevenue.Name = "chrtGenreRevenue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtGenreRevenue.Series.Add(series2);
            this.chrtGenreRevenue.Size = new System.Drawing.Size(673, 400);
            this.chrtGenreRevenue.TabIndex = 33;
            this.chrtGenreRevenue.Text = "GenreRevenue";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Location = new System.Drawing.Point(9, 233);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(51, 13);
            this.lbRevenue.TabIndex = 34;
            this.lbRevenue.Text = "Revenue";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(383, 478);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(36, 13);
            this.lbGenre.TabIndex = 35;
            this.lbGenre.Text = "Genre";
            // 
            // frmGenreRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbRevenue);
            this.Controls.Add(this.chrtGenreRevenue);
            this.Controls.Add(this.mnuNavigation);
            this.Name = "frmGenreRevenue";
            this.Text = "GenreRevenue";
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGenreRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGenreRevenue;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label lbGenre;
    }
}