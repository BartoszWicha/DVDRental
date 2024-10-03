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
            this.txtSName = new System.Windows.Forms.TextBox();
            this.dgCurrentlyRented = new System.Windows.Forms.DataGridView();
            this.grpReturnBox = new System.Windows.Forms.GroupBox();
            this.dgDVDToReturn = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnter = new System.Windows.Forms.Button();
            this.RentedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedDVDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedDateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDVDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentlyRented)).BeginInit();
            this.grpReturnBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDVDToReturn)).BeginInit();
            this.mnuNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Member Surname";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(17, 109);
            this.txtSName.MaxLength = 30;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(202, 20);
            this.txtSName.TabIndex = 0;
            // 
            // dgCurrentlyRented
            // 
            this.dgCurrentlyRented.AllowUserToAddRows = false;
            this.dgCurrentlyRented.AllowUserToDeleteRows = false;
            this.dgCurrentlyRented.AllowUserToResizeColumns = false;
            this.dgCurrentlyRented.AllowUserToResizeRows = false;
            this.dgCurrentlyRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrentlyRented.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentedID,
            this.RentedDVDTitle,
            this.RentedDateRented,
            this.RentedCost});
            this.dgCurrentlyRented.Location = new System.Drawing.Point(59, 31);
            this.dgCurrentlyRented.Name = "dgCurrentlyRented";
            this.dgCurrentlyRented.Size = new System.Drawing.Size(445, 122);
            this.dgCurrentlyRented.TabIndex = 18;
            this.dgCurrentlyRented.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCurrentlyRented_CellMouseClick);
            // 
            // grpReturnBox
            // 
            this.grpReturnBox.Controls.Add(this.dgDVDToReturn);
            this.grpReturnBox.Controls.Add(this.btnReturn);
            this.grpReturnBox.Controls.Add(this.dgCurrentlyRented);
            this.grpReturnBox.Location = new System.Drawing.Point(1, 444);
            this.grpReturnBox.Name = "grpReturnBox";
            this.grpReturnBox.Size = new System.Drawing.Size(592, 403);
            this.grpReturnBox.TabIndex = 19;
            this.grpReturnBox.TabStop = false;
            this.grpReturnBox.Text = "Return DVDs";
            this.grpReturnBox.Visible = false;
            // 
            // dgDVDToReturn
            // 
            this.dgDVDToReturn.AllowUserToAddRows = false;
            this.dgDVDToReturn.AllowUserToDeleteRows = false;
            this.dgDVDToReturn.AllowUserToResizeColumns = false;
            this.dgDVDToReturn.AllowUserToResizeRows = false;
            this.dgDVDToReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDVDToReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReturnID,
            this.ReturnDVDTitle,
            this.ReturnDateRented,
            this.ReturnCost});
            this.dgDVDToReturn.Location = new System.Drawing.Point(59, 181);
            this.dgDVDToReturn.Name = "dgDVDToReturn";
            this.dgDVDToReturn.Size = new System.Drawing.Size(445, 122);
            this.dgDVDToReturn.TabIndex = 19;
            this.dgDVDToReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDVDToReturn_CellClick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReturn.Location = new System.Drawing.Point(197, 349);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 28);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClick});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(605, 24);
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
            // dgMembers
            // 
            this.dgMembers.AllowUserToAddRows = false;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.PhoneNum});
            this.dgMembers.Location = new System.Drawing.Point(17, 186);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.Size = new System.Drawing.Size(445, 197);
            this.dgMembers.TabIndex = 23;
            this.dgMembers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMembers_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "FName";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "SName";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.Name = "PhoneNum";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(252, 98);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(160, 41);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // RentedID
            // 
            this.RentedID.HeaderText = "ID";
            this.RentedID.MaxInputLength = 3;
            this.RentedID.Name = "RentedID";
            // 
            // RentedDVDTitle
            // 
            this.RentedDVDTitle.HeaderText = "DVDTitle";
            this.RentedDVDTitle.MaxInputLength = 30;
            this.RentedDVDTitle.Name = "RentedDVDTitle";
            // 
            // RentedDateRented
            // 
            this.RentedDateRented.HeaderText = "DateRented";
            this.RentedDateRented.Name = "RentedDateRented";
            // 
            // RentedCost
            // 
            this.RentedCost.HeaderText = "Cost";
            this.RentedCost.MaxInputLength = 6;
            this.RentedCost.Name = "RentedCost";
            // 
            // ReturnID
            // 
            this.ReturnID.HeaderText = "ID";
            this.ReturnID.MaxInputLength = 3;
            this.ReturnID.Name = "ReturnID";
            // 
            // ReturnDVDTitle
            // 
            this.ReturnDVDTitle.HeaderText = "DVDTitle";
            this.ReturnDVDTitle.MaxInputLength = 30;
            this.ReturnDVDTitle.Name = "ReturnDVDTitle";
            // 
            // ReturnDateRented
            // 
            this.ReturnDateRented.HeaderText = "DateRented";
            this.ReturnDateRented.MaxInputLength = 9;
            this.ReturnDateRented.Name = "ReturnDateRented";
            // 
            // ReturnCost
            // 
            this.ReturnCost.HeaderText = "Cost";
            this.ReturnCost.MaxInputLength = 9;
            this.ReturnCost.Name = "ReturnCost";
            // 
            // frmReturnDVDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(605, 849);
            this.Controls.Add(this.dgMembers);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.mnuNavigation);
            this.Controls.Add(this.grpReturnBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSName);
            this.Name = "frmReturnDVDs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnDVDs";
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentlyRented)).EndInit();
            this.grpReturnBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDVDToReturn)).EndInit();
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.DataGridView dgCurrentlyRented;
        private System.Windows.Forms.GroupBox grpReturnBox;
        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgDVDToReturn;
        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedDVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedDateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDVDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnCost;
    }
}