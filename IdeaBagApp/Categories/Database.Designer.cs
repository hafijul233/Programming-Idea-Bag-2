namespace _IdeaBagApp.Categories
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.databaseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.chooseProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseMenuStrip
            // 
            this.databaseMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.databaseMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.databaseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseProgramToolStripMenuItem,
            this.toolStripComboBox1,
            this.quitToolStripMenuItem});
            this.databaseMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.databaseMenuStrip.Name = "databaseMenuStrip";
            this.databaseMenuStrip.Size = new System.Drawing.Size(1344, 37);
            this.databaseMenuStrip.TabIndex = 0;
            this.databaseMenuStrip.Text = "menuStrip1";
            // 
            // chooseProgramToolStripMenuItem
            // 
            this.chooseProgramToolStripMenuItem.Name = "chooseProgramToolStripMenuItem";
            this.chooseProgramToolStripMenuItem.Size = new System.Drawing.Size(158, 33);
            this.chooseProgramToolStripMenuItem.Text = "Choose Program";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.DropDownWidth = 300;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(58, 33);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1344, 744);
            this.Controls.Add(this.databaseMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.databaseMenuStrip;
            this.Name = "Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Database_FormClosing);
            this.databaseMenuStrip.ResumeLayout(false);
            this.databaseMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip databaseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem chooseProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}