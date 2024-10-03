namespace DVDRental
{
    partial class frmRemoveMem
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
            this.dgMemCancelled = new System.Windows.Forms.DataGridView();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemCancelled)).BeginInit();
            this.mnuNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMemCancelled
            // 
            this.dgMemCancelled.AllowDrop = true;
            this.dgMemCancelled.AllowUserToAddRows = false;
            this.dgMemCancelled.AllowUserToDeleteRows = false;
            this.dgMemCancelled.AllowUserToResizeColumns = false;
            this.dgMemCancelled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemCancelled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FName,
            this.SName,
            this.PhoneNum});
            this.dgMemCancelled.Enabled = false;
            this.dgMemCancelled.Location = new System.Drawing.Point(98, 111);
            this.dgMemCancelled.Name = "dgMemCancelled";
            this.dgMemCancelled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMemCancelled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMemCancelled.ShowEditingIcon = false;
            this.dgMemCancelled.Size = new System.Drawing.Size(594, 308);
            this.dgMemCancelled.TabIndex = 0;
            this.dgMemCancelled.Visible = false;
            // 
            // FName
            // 
            this.FName.HeaderText = "FName";
            this.FName.MaxInputLength = 30;
            this.FName.Name = "FName";
            this.FName.Width = 200;
            // 
            // SName
            // 
            this.SName.HeaderText = "SName";
            this.SName.MaxInputLength = 30;
            this.SName.Name = "SName";
            this.SName.Width = 200;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.MaxInputLength = 9;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Cancelled Members";
            this.label1.Visible = false;
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
            // frmRemoveMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuNavigation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMemCancelled);
            this.Name = "frmRemoveMem";
            this.Text = "Remove Members";
            ((System.ComponentModel.ISupportInitialize)(this.dgMemCancelled)).EndInit();
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMemCancelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
    }
}