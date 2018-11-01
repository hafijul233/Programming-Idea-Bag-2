namespace _IdeaBagApp.Categories
{
    partial class Numbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numbers));
            this.numbersMenuStrip = new System.Windows.Forms.MenuStrip();
            this.chooseProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numbersMenuStrip
            // 
            this.numbersMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numbersMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.numbersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseProgramToolStripMenuItem,
            this.toolStripComboBox1,
            this.quitToolStripMenuItem});
            this.numbersMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.numbersMenuStrip.Name = "numbersMenuStrip";
            this.numbersMenuStrip.Size = new System.Drawing.Size(1344, 37);
            this.numbersMenuStrip.TabIndex = 0;
            this.numbersMenuStrip.Text = "menuStrip1";
            // 
            // chooseProgramToolStripMenuItem
            // 
            this.chooseProgramToolStripMenuItem.Name = "chooseProgramToolStripMenuItem";
            this.chooseProgramToolStripMenuItem.Size = new System.Drawing.Size(170, 33);
            this.chooseProgramToolStripMenuItem.Text = "Choose Program";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(62, 33);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 744);
            this.Controls.Add(this.numbersMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.numbersMenuStrip;
            this.Name = "Numbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numbers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Numbers_FormClosing);
            this.numbersMenuStrip.ResumeLayout(false);
            this.numbersMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip numbersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem chooseProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}