namespace DVDRental
{
    partial class frmDVDModify
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDVDDetails = new System.Windows.Forms.GroupBox();
            this.txtTitleToUpdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMatchingDVDs = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.grpDVDDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatchingDVDs)).BeginInit();
            this.mnuNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(186, 48);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(224, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(42, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "DVD Title";
            // 
            // grpDVDDetails
            // 
            this.grpDVDDetails.Controls.Add(this.txtTitleToUpdt);
            this.grpDVDDetails.Controls.Add(this.label4);
            this.grpDVDDetails.Controls.Add(this.cmbGenre);
            this.grpDVDDetails.Controls.Add(this.cmbCateg);
            this.grpDVDDetails.Controls.Add(this.btnSubmit);
            this.grpDVDDetails.Controls.Add(this.label2);
            this.grpDVDDetails.Controls.Add(this.label1);
            this.grpDVDDetails.Location = new System.Drawing.Point(208, 267);
            this.grpDVDDetails.Name = "grpDVDDetails";
            this.grpDVDDetails.Size = new System.Drawing.Size(684, 310);
            this.grpDVDDetails.TabIndex = 11;
            this.grpDVDDetails.TabStop = false;
            this.grpDVDDetails.Text = "DVD Details";
            this.grpDVDDetails.Visible = false;
            // 
            // txtTitleToUpdt
            // 
            this.txtTitleToUpdt.Location = new System.Drawing.Point(298, 39);
            this.txtTitleToUpdt.MaxLength = 30;
            this.txtTitleToUpdt.Name = "txtTitleToUpdt";
            this.txtTitleToUpdt.Size = new System.Drawing.Size(224, 20);
            this.txtTitleToUpdt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(154, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "DVD Title";
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(297, 153);
            this.cmbGenre.MaxDropDownItems = 6;
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(226, 21);
            this.cmbGenre.TabIndex = 6;
            // 
            // cmbCateg
            // 
            this.cmbCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Location = new System.Drawing.Point(297, 98);
            this.cmbCateg.MaxDropDownItems = 6;
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(226, 21);
            this.cmbCateg.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSubmit.Location = new System.Drawing.Point(230, 250);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(197, 44);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(154, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(154, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genre";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSearch.Location = new System.Drawing.Point(122, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mnuBackClick
            // 
            this.mnuBackClick.Name = "mnuBackClick";
            this.mnuBackClick.Size = new System.Drawing.Size(80, 20);
            this.mnuBackClick.Text = "Main Menu";
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
            this.dgMatchingDVDs.Location = new System.Drawing.Point(506, 48);
            this.dgMatchingDVDs.MultiSelect = false;
            this.dgMatchingDVDs.Name = "dgMatchingDVDs";
            this.dgMatchingDVDs.Size = new System.Drawing.Size(543, 167);
            this.dgMatchingDVDs.TabIndex = 15;
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
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(80, 20);
            this.mnuBack.Text = "Main Menu";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(1103, 24);
            this.mnuNavigation.TabIndex = 13;
            this.mnuNavigation.Text = "menuStrip1";
            // 
            // frmDVDModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1103, 651);
            this.Controls.Add(this.dgMatchingDVDs);
            this.Controls.Add(this.mnuNavigation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpDVDDetails);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Name = "frmDVDModify";
            this.Text = " DVDs";
            this.Load += new System.EventHandler(this.frmModifyDVD_Load);
            this.grpDVDDetails.ResumeLayout(false);
            this.grpDVDDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatchingDVDs)).EndInit();
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDVDDetails;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTitleToUpdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.DataGridView dgMatchingDVDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.MenuStrip mnuNavigation;
    }
}