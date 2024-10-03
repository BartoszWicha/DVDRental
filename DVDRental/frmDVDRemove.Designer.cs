namespace DVDRental
{
    partial class frmDVDRemove
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMatchingDVDs = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatchingDVDs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSearch.Location = new System.Drawing.Point(187, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 39);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(187, 62);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(224, 20);
            this.txtTitle.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(43, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "DVD Title";
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(1046, 24);
            this.mnuNavigation.TabIndex = 19;
            this.mnuNavigation.Text = "menuStrip1";
            // 
            // mnuBackClick
            // 
            this.mnuBackClick.Name = "mnuBackClick";
            this.mnuBackClick.Size = new System.Drawing.Size(32, 19);
            // 
            // dgMatchingDVDs
            // 
            this.dgMatchingDVDs.AllowUserToAddRows = false;
            this.dgMatchingDVDs.AllowUserToDeleteRows = false;
            this.dgMatchingDVDs.AllowUserToResizeColumns = false;
            this.dgMatchingDVDs.AllowUserToResizeRows = false;
            this.dgMatchingDVDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatchingDVDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DVDID,
            this.DVDTitle,
            this.Status,
            this.Category,
            this.Genre});
            this.dgMatchingDVDs.Location = new System.Drawing.Point(480, 56);
            this.dgMatchingDVDs.MultiSelect = false;
            this.dgMatchingDVDs.Name = "dgMatchingDVDs";
            this.dgMatchingDVDs.Size = new System.Drawing.Size(543, 207);
            this.dgMatchingDVDs.TabIndex = 20;
            this.dgMatchingDVDs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMatchingDVDs_CellClick);
            // 
            // DVDID
            // 
            this.DVDID.HeaderText = "DVDID";
            this.DVDID.MaxInputLength = 4;
            this.DVDID.Name = "DVDID";
            this.DVDID.ReadOnly = true;
            // 
            // DVDTitle
            // 
            this.DVDTitle.HeaderText = "DVDTitle";
            this.DVDTitle.MaxInputLength = 30;
            this.DVDTitle.Name = "DVDTitle";
            this.DVDTitle.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MaxInputLength = 1;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MaxInputLength = 2;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MaxInputLength = 30;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // frmRemoveDVDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.dgMatchingDVDs);
            this.Controls.Add(this.mnuNavigation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Name = "frmRemoveDVDs";
            this.Text = "RemoveDVDs";
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatchingDVDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.DataGridView dgMatchingDVDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
    }
}