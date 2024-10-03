namespace DVDRental
{
    partial class frmYearlyRevenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chrtYearly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbMonths = new System.Windows.Forms.Label();
            this.mnuNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtYearly)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClick});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(1097, 24);
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
            // cmbYears
            // 
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.cmbYears.Location = new System.Drawing.Point(89, 46);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(180, 21);
            this.cmbYears.TabIndex = 31;
            this.cmbYears.SelectedIndexChanged += new System.EventHandler(this.cmbYears_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Year";
            // 
            // chrtYearly
            // 
            this.chrtYearly.BackColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea1.Name = "ChartArea1";
            this.chrtYearly.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtYearly.Legends.Add(legend1);
            this.chrtYearly.Location = new System.Drawing.Point(163, 87);
            this.chrtYearly.Name = "chrtYearly";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtYearly.Series.Add(series1);
            this.chrtYearly.Size = new System.Drawing.Size(861, 456);
            this.chrtYearly.TabIndex = 33;
            this.chrtYearly.Text = "chart1";
            this.chrtYearly.Visible = false;
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Location = new System.Drawing.Point(160, 296);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(29, 13);
            this.lbEuro.TabIndex = 34;
            this.lbEuro.Text = "Euro";
            this.lbEuro.Visible = false;
            // 
            // lbMonths
            // 
            this.lbMonths.AutoSize = true;
            this.lbMonths.Location = new System.Drawing.Point(558, 530);
            this.lbMonths.Name = "lbMonths";
            this.lbMonths.Size = new System.Drawing.Size(42, 13);
            this.lbMonths.TabIndex = 35;
            this.lbMonths.Text = "Months";
            this.lbMonths.Visible = false;
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1097, 729);
            this.Controls.Add(this.lbMonths);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.chrtYearly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYears);
            this.Controls.Add(this.mnuNavigation);
            this.Name = "frmYearlyRevenue";
            this.Text = "YearlyRevenue";
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtYearly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtYearly;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbMonths;
    }
}