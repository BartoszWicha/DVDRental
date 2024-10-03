namespace DVDRental
{
    partial class frmMemberModify
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
            this.txtEnterSName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpUpdateValues = new System.Windows.Forms.GroupBox();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.grpUpdateValues.SuspendLayout();
            this.mnuNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnterSName
            // 
            this.txtEnterSName.Location = new System.Drawing.Point(376, 60);
            this.txtEnterSName.MaxLength = 20;
            this.txtEnterSName.Name = "txtEnterSName";
            this.txtEnterSName.Size = new System.Drawing.Size(224, 20);
            this.txtEnterSName.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(629, 54);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(161, 28);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(243, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Surname";
            // 
            // dgMembers
            // 
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FName,
            this.SName,
            this.PhoneNum,
            this.Status});
            this.dgMembers.Location = new System.Drawing.Point(249, 109);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.Size = new System.Drawing.Size(550, 197);
            this.dgMembers.TabIndex = 2;
            this.dgMembers.Visible = false;
            this.dgMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMembers_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 3;
            this.ID.Name = "ID";
            // 
            // FName
            // 
            this.FName.HeaderText = "FName";
            this.FName.MaxInputLength = 30;
            this.FName.Name = "FName";
            // 
            // SName
            // 
            this.SName.HeaderText = "SName";
            this.SName.MaxInputLength = 30;
            this.SName.Name = "SName";
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.MaxInputLength = 9;
            this.PhoneNum.Name = "PhoneNum";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MaxInputLength = 1;
            this.Status.Name = "Status";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(341, 116);
            this.txtSName.MaxLength = 20;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(224, 20);
            this.txtSName.TabIndex = 4;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(341, 216);
            this.txtPhoneNum.MaxLength = 12;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(224, 20);
            this.txtPhoneNum.TabIndex = 26;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(341, 32);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(224, 20);
            this.txtFName.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnUpdate.Location = new System.Drawing.Point(221, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(211, 58);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(76, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(76, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(76, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phone Number";
            // 
            // grpUpdateValues
            // 
            this.grpUpdateValues.Controls.Add(this.txtSName);
            this.grpUpdateValues.Controls.Add(this.txtPhoneNum);
            this.grpUpdateValues.Controls.Add(this.txtFName);
            this.grpUpdateValues.Controls.Add(this.btnUpdate);
            this.grpUpdateValues.Controls.Add(this.label3);
            this.grpUpdateValues.Controls.Add(this.label1);
            this.grpUpdateValues.Controls.Add(this.label4);
            this.grpUpdateValues.Location = new System.Drawing.Point(214, 312);
            this.grpUpdateValues.Name = "grpUpdateValues";
            this.grpUpdateValues.Size = new System.Drawing.Size(625, 351);
            this.grpUpdateValues.TabIndex = 28;
            this.grpUpdateValues.TabStop = false;
            this.grpUpdateValues.Text = "Member Details";
            this.grpUpdateValues.Visible = false;
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClick});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(1048, 24);
            this.mnuNavigation.TabIndex = 29;
            this.mnuNavigation.Text = "menuStrip1";
            // 
            // mnuBackClick
            // 
            this.mnuBackClick.Name = "mnuBackClick";
            this.mnuBackClick.Size = new System.Drawing.Size(80, 20);
            this.mnuBackClick.Text = "Main Menu";
            this.mnuBackClick.Click += new System.EventHandler(this.mnuBackClick_Click);
            // 
            // frmMemberModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1048, 664);
            this.Controls.Add(this.mnuNavigation);
            this.Controls.Add(this.grpUpdateValues);
            this.Controls.Add(this.dgMembers);
            this.Controls.Add(this.txtEnterSName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Name = "frmMemberModify";
            this.Text = "UpdateMem";
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.grpUpdateValues.ResumeLayout(false);
            this.grpUpdateValues.PerformLayout();
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterSName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpUpdateValues;
        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}