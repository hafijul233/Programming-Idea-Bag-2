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
            this.numbersMenuStrip.Size = new System.Drawing.Size(1344, 40);
            this.numbersMenuStrip.TabIndex = 0;
            this.numbersMenuStrip.Text = "menuStrip1";
            // 
            // chooseProgramToolStripMenuItem
            // 
            this.chooseProgramToolStripMenuItem.Name = "chooseProgramToolStripMenuItem";
            this.chooseProgramToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.chooseProgramToolStripMenuItem.Text = "Choose Program";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoSize = false;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.DropDownWidth = 300;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Alarm Clock",
            "Basic Calculator",
            "Change Return",
            "Circular Primes",
            "Coin Flip Simulation",
            "Distance Calculator",
            "Factorial Finder",
            "Fibonacci Sequence",
            "Friday the 13th",
            "Gravity Simulation",
            "Gray Code",
            "Guess the Number",
            "Happy Numbers",
            "Houseold budget",
            "Latin Squares",
            "Least /greatest Common Denominator",
            "Lotto",
            "Mortgage Calculator",
            "Neon Number",
            "Next Prime Number",
            "Nth Natural Number",
            "Number Base Converter",
            "Number of Days",
            "Pascal\'s Triangle",
            "Pi Nth Digit",
            "prime Factorization",
            "Pseudo Random Number Generator",
            "r to Nth Digit",
            "Ramanujan Number",
            "Roman Number Generator",
            "Roman to Arabic Converter",
            "Tax Calculator",
            "Unit Converter",
            "UUID",
            "Vigentere Cipher"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(400, 36);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(62, 36);
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