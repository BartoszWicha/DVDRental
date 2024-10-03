namespace DVDRental
{
    partial class frmMemberRemove
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
            this.txtEnterSName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackClick});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(800, 24);
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
            // txtEnterSName
            // 
            this.txtEnterSName.Location = new System.Drawing.Point(230, 59);
            this.txtEnterSName.MaxLength = 20;
            this.txtEnterSName.Name = "txtEnterSName";
            this.txtEnterSName.Size = new System.Drawing.Size(224, 20);
            this.txtEnterSName.TabIndex = 18;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(483, 53);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(161, 28);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(97, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Surname";
            // 
            // dgMembers
            // 
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FName,
            this.SName,
            this.PNum});
            this.dgMembers.Location = new System.Drawing.Point(162, 167);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.Size = new System.Drawing.Size(443, 197);
            this.dgMembers.TabIndex = 22;
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
            // PNum
            // 
            this.PNum.HeaderText = "PhoneNum";
            this.PNum.MaxInputLength = 9;
            this.PNum.Name = "PNum";
            // 
            // frmMemberRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMembers);
            this.Controls.Add(this.txtEnterSName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnuNavigation);
            this.Name = "frmMemberRemove";
            this.Text = "Remove Members";
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.TextBox txtEnterSName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNum;
    }
}