namespace DVDRental
{
    partial class frmReturnDVDs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.dgCurrentlyRented = new System.Windows.Forms.DataGridView();
            this.CartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartDVDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReturnBox = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.chkRentedItems = new System.Windows.Forms.CheckedListBox();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentlyRented)).BeginInit();
            this.grpReturnBox.SuspendLayout();
            this.mnuNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Member ID";
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(212, 40);
            this.txtMemID.MaxLength = 4;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(202, 20);
            this.txtMemID.TabIndex = 0;
            // 
            // dgCurrentlyRented
            // 
            this.dgCurrentlyRented.AllowUserToAddRows = false;
            this.dgCurrentlyRented.AllowUserToDeleteRows = false;
            this.dgCurrentlyRented.AllowUserToResizeColumns = false;
            this.dgCurrentlyRented.AllowUserToResizeRows = false;
            this.dgCurrentlyRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrentlyRented.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartID,
            this.CartDVDTitle,
            this.CartGenre,
            this.DateRented});
            this.dgCurrentlyRented.Enabled = false;
            this.dgCurrentlyRented.Location = new System.Drawing.Point(26, 28);
            this.dgCurrentlyRented.Name = "dgCurrentlyRented";
            this.dgCurrentlyRented.Size = new System.Drawing.Size(445, 122);
            this.dgCurrentlyRented.TabIndex = 18;
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
            // DateRented
            // 
            this.DateRented.HeaderText = "DateRented";
            this.DateRented.Name = "DateRented";
            // 
            // grpReturnBox
            // 
            this.grpReturnBox.Controls.Add(this.btnReturn);
            this.grpReturnBox.Controls.Add(this.chkRentedItems);
            this.grpReturnBox.Controls.Add(this.dgCurrentlyRented);
            this.grpReturnBox.Location = new System.Drawing.Point(1, 87);
            this.grpReturnBox.Name = "grpReturnBox";
            this.grpReturnBox.Size = new System.Drawing.Size(1079, 490);
            this.grpReturnBox.TabIndex = 19;
            this.grpReturnBox.TabStop = false;
            this.grpReturnBox.Text = "Return DVDs";
            this.grpReturnBox.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReturn.Location = new System.Drawing.Point(11, 387);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 28);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // chkRentedItems
            // 
            this.chkRentedItems.FormattingEnabled = true;
            this.chkRentedItems.Location = new System.Drawing.Point(26, 181);
            this.chkRentedItems.Name = "chkRentedItems";
            this.chkRentedItems.Size = new System.Drawing.Size(123, 154);
            this.chkRentedItems.TabIndex = 2;
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClick});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(1092, 24);
            this.mnuNavigation.TabIndex = 20;
            this.mnuNavigation.Text = "menuStrip1";
            // 
            // mnuBackClick
            // 
            this.mnuBackClick.Name = "mnuBackClick";
            this.mnuBackClick.Size = new System.Drawing.Size(80, 20);
            this.mnuBackClick.Text = "Main Menu";
            this.mnuBackClick.Click += new System.EventHandler(this.mnuBackClick_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(450, 32);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(161, 28);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmReturnDVDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1092, 674);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.mnuNavigation);
            this.Controls.Add(this.grpReturnBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemID);
            this.Name = "frmReturnDVDs";
            this.Text = "ReturnDVDs";
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentlyRented)).EndInit();
            this.grpReturnBox.ResumeLayout(false);
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.DataGridView dgCurrentlyRented;
        private System.Windows.Forms.GroupBox grpReturnBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartDVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRented;
        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.CheckedListBox chkRentedItems;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReturn;
    }
}