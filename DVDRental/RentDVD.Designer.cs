namespace DVDRental
{
    partial class frmRentDVD
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
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearchDVDs = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgSimilarDVDs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.CartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartDVDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConclude = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDVDTitle = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.mnuNavigation.SuspendLayout();
            this.grpSearchDVDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSimilarDVDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClick});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(1022, 24);
            this.mnuNavigation.TabIndex = 9;
            this.mnuNavigation.Text = "menuStrip1";
            // 
            // mnuBackClick
            // 
            this.mnuBackClick.Name = "mnuBackClick";
            this.mnuBackClick.Size = new System.Drawing.Size(80, 20);
            this.mnuBackClick.Text = "Main Menu";
            this.mnuBackClick.Click += new System.EventHandler(this.mnuBackClick_Click);
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(218, 60);
            this.txtMemID.MaxLength = 4;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(202, 20);
            this.txtMemID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Member ID";
            // 
            // grpSearchDVDs
            // 
            this.grpSearchDVDs.Controls.Add(this.label3);
            this.grpSearchDVDs.Controls.Add(this.dgSimilarDVDs);
            this.grpSearchDVDs.Controls.Add(this.dgCart);
            this.grpSearchDVDs.Controls.Add(this.btnConclude);
            this.grpSearchDVDs.Controls.Add(this.btnSearch);
            this.grpSearchDVDs.Controls.Add(this.label2);
            this.grpSearchDVDs.Controls.Add(this.txtDVDTitle);
            this.grpSearchDVDs.Location = new System.Drawing.Point(31, 104);
            this.grpSearchDVDs.Name = "grpSearchDVDs";
            this.grpSearchDVDs.Size = new System.Drawing.Size(979, 475);
            this.grpSearchDVDs.TabIndex = 13;
            this.grpSearchDVDs.TabStop = false;
            this.grpSearchDVDs.Text = "Rental";
            this.grpSearchDVDs.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(564, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cart";
            // 
            // dgSimilarDVDs
            // 
            this.dgSimilarDVDs.AllowUserToAddRows = false;
            this.dgSimilarDVDs.AllowUserToDeleteRows = false;
            this.dgSimilarDVDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSimilarDVDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DVDTitle,
            this.Genre});
            this.dgSimilarDVDs.Location = new System.Drawing.Point(11, 171);
            this.dgSimilarDVDs.MultiSelect = false;
            this.dgSimilarDVDs.Name = "dgSimilarDVDs";
            this.dgSimilarDVDs.Size = new System.Drawing.Size(344, 122);
            this.dgSimilarDVDs.TabIndex = 5;
            this.dgSimilarDVDs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSimilarDVDs_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 3;
            this.ID.Name = "ID";
            // 
            // DVDTitle
            // 
            this.DVDTitle.HeaderText = "DVDTitle";
            this.DVDTitle.MaxInputLength = 30;
            this.DVDTitle.Name = "DVDTitle";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MaxInputLength = 30;
            this.Genre.Name = "Genre";
            // 
            // dgCart
            // 
            this.dgCart.AllowUserToAddRows = false;
            this.dgCart.AllowUserToDeleteRows = false;
            this.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartID,
            this.CartDVDTitle,
            this.CartGenre});
            this.dgCart.Location = new System.Drawing.Point(569, 171);
            this.dgCart.Name = "dgCart";
            this.dgCart.Size = new System.Drawing.Size(344, 122);
            this.dgCart.TabIndex = 6;
            this.dgCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCart_CellClick);
            // 
            // CartID
            // 
            this.CartID.HeaderText = "ID";
            this.CartID.Name = "CartID";
            // 
            // CartDVDTitle
            // 
            this.CartDVDTitle.HeaderText = "DVDTitle";
            this.CartDVDTitle.Name = "CartDVDTitle";
            // 
            // CartGenre
            // 
            this.CartGenre.HeaderText = "Genre";
            this.CartGenre.Name = "CartGenre";
            // 
            // btnConclude
            // 
            this.btnConclude.Location = new System.Drawing.Point(399, 408);
            this.btnConclude.Name = "btnConclude";
            this.btnConclude.Size = new System.Drawing.Size(160, 41);
            this.btnConclude.TabIndex = 4;
            this.btnConclude.Text = "Complete Transaction";
            this.btnConclude.UseVisualStyleBackColor = true;
            this.btnConclude.Click += new System.EventHandler(this.btnConclude_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(66, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(173, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "DVD Title";
            // 
            // txtDVDTitle
            // 
            this.txtDVDTitle.Location = new System.Drawing.Point(153, 33);
            this.txtDVDTitle.MaxLength = 30;
            this.txtDVDTitle.Name = "txtDVDTitle";
            this.txtDVDTitle.Size = new System.Drawing.Size(202, 20);
            this.txtDVDTitle.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(456, 49);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(160, 41);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1022, 591);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.grpSearchDVDs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.mnuNavigation);
            this.Name = "frmRentDVD";
            this.Text = "RentDVD";
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.grpSearchDVDs.ResumeLayout(false);
            this.grpSearchDVDs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSimilarDVDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearchDVDs;
        private System.Windows.Forms.DataGridView dgSimilarDVDs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridView dgCart;
        private System.Windows.Forms.Button btnConclude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartDVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartGenre;
        private System.Windows.Forms.Button btnEnter;
    }
}