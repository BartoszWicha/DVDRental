namespace DVDRental
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.manageCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDVDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mnuNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.AutoSize = false;
            this.mnuNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.mnuNavigation.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCategoriesToolStripMenuItem,
            this.manageDVDsToolStripMenuItem,
            this.manageMembersToolStripMenuItem,
            this.processRentalsToolStripMenuItem,
            this.revenueReportsToolStripMenuItem});
            this.mnuNavigation.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Padding = new System.Windows.Forms.Padding(0);
            this.mnuNavigation.Size = new System.Drawing.Size(766, 52);
            this.mnuNavigation.Stretch = false;
            this.mnuNavigation.TabIndex = 0;
            this.mnuNavigation.Text = "menuStrip1";
            // 
            // manageCategoriesToolStripMenuItem
            // 
            this.manageCategoriesToolStripMenuItem.AutoSize = false;
            this.manageCategoriesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.manageCategoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCategoryToolStripMenuItem,
            this.modifyCategoryToolStripMenuItem});
            this.manageCategoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.manageCategoriesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageCategoriesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            this.manageCategoriesToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.manageCategoriesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.manageCategoriesToolStripMenuItem.Size = new System.Drawing.Size(150, 50);
            this.manageCategoriesToolStripMenuItem.Text = "Manage Categories";
            // 
            // createCategoryToolStripMenuItem
            // 
            this.createCategoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.createCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createCategoryToolStripMenuItem.Name = "createCategoryToolStripMenuItem";
            this.createCategoryToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.createCategoryToolStripMenuItem.Text = "Create Category";
            this.createCategoryToolStripMenuItem.Click += new System.EventHandler(this.createCategoryToolStripMenuItem_Click);
            // 
            // modifyCategoryToolStripMenuItem
            // 
            this.modifyCategoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.modifyCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modifyCategoryToolStripMenuItem.Name = "modifyCategoryToolStripMenuItem";
            this.modifyCategoryToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.modifyCategoryToolStripMenuItem.Text = "Modify Category";
            this.modifyCategoryToolStripMenuItem.Click += new System.EventHandler(this.modifyCategoryToolStripMenuItem_Click);
            // 
            // manageDVDsToolStripMenuItem
            // 
            this.manageDVDsToolStripMenuItem.AutoSize = false;
            this.manageDVDsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.manageDVDsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDVDToolStripMenuItem,
            this.modifyDVDToolStripMenuItem,
            this.removeDVDToolStripMenuItem});
            this.manageDVDsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.manageDVDsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageDVDsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageDVDsToolStripMenuItem.Name = "manageDVDsToolStripMenuItem";
            this.manageDVDsToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.manageDVDsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.manageDVDsToolStripMenuItem.Size = new System.Drawing.Size(150, 50);
            this.manageDVDsToolStripMenuItem.Text = "Manage DVDs";
            // 
            // addDVDToolStripMenuItem
            // 
            this.addDVDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.addDVDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addDVDToolStripMenuItem.Name = "addDVDToolStripMenuItem";
            this.addDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addDVDToolStripMenuItem.Text = "Add DVD";
            this.addDVDToolStripMenuItem.Click += new System.EventHandler(this.addDVDToolStripMenuItem_Click);
            // 
            // modifyDVDToolStripMenuItem
            // 
            this.modifyDVDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.modifyDVDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modifyDVDToolStripMenuItem.Name = "modifyDVDToolStripMenuItem";
            this.modifyDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.modifyDVDToolStripMenuItem.Text = "Modify DVD";
            this.modifyDVDToolStripMenuItem.Click += new System.EventHandler(this.modifyDVDToolStripMenuItem_Click);
            // 
            // removeDVDToolStripMenuItem
            // 
            this.removeDVDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.removeDVDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeDVDToolStripMenuItem.Name = "removeDVDToolStripMenuItem";
            this.removeDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.removeDVDToolStripMenuItem.Text = "Remove DVD";
            this.removeDVDToolStripMenuItem.Click += new System.EventHandler(this.removeDVDToolStripMenuItem_Click);
            // 
            // manageMembersToolStripMenuItem
            // 
            this.manageMembersToolStripMenuItem.AutoSize = false;
            this.manageMembersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.manageMembersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.manageMembersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.manageMembersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageMembersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageMembersToolStripMenuItem.Name = "manageMembersToolStripMenuItem";
            this.manageMembersToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.manageMembersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.manageMembersToolStripMenuItem.Size = new System.Drawing.Size(150, 50);
            this.manageMembersToolStripMenuItem.Text = "Manage Members";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.registerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.modifyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.cancelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // processRentalsToolStripMenuItem
            // 
            this.processRentalsToolStripMenuItem.AutoSize = false;
            this.processRentalsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.processRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.processRentalsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.processRentalsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.processRentalsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processRentalsToolStripMenuItem.Name = "processRentalsToolStripMenuItem";
            this.processRentalsToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.processRentalsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.processRentalsToolStripMenuItem.Size = new System.Drawing.Size(150, 50);
            this.processRentalsToolStripMenuItem.Text = "Process Rentals";
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.rentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.rentToolStripMenuItem.Text = "Rent";
            this.rentToolStripMenuItem.Click += new System.EventHandler(this.rentToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.returnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // revenueReportsToolStripMenuItem
            // 
            this.revenueReportsToolStripMenuItem.AutoSize = false;
            this.revenueReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.revenueReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.revenueReportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.revenueReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.revenueReportsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.revenueReportsToolStripMenuItem.Name = "revenueReportsToolStripMenuItem";
            this.revenueReportsToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.revenueReportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.revenueReportsToolStripMenuItem.Size = new System.Drawing.Size(150, 50);
            this.revenueReportsToolStripMenuItem.Text = "Revenue Reports";
            // 
            // yearlyToolStripMenuItem
            // 
            this.yearlyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.yearlyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yearlyToolStripMenuItem.Name = "yearlyToolStripMenuItem";
            this.yearlyToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.yearlyToolStripMenuItem.Text = "Yearly";
            this.yearlyToolStripMenuItem.Click += new System.EventHandler(this.yearlyToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.genreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.mnuNavigation);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.MainMenuStrip = this.mnuNavigation;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem manageDVDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyDVDToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}