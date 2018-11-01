namespace _IdeaBagApp.Number
{
    partial class FactorialFinder
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.InputNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.Location = new System.Drawing.Point(17, 223);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(508, 39);
            this.OutputTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Factorial Value:";
            // 
            // FactorialButton
            // 
            this.FactorialButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FactorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactorialButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FactorialButton.Location = new System.Drawing.Point(140, 286);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(244, 84);
            this.FactorialButton.TabIndex = 10;
            this.FactorialButton.Text = "Factorial";
            this.FactorialButton.UseVisualStyleBackColor = false;
            this.FactorialButton.Click += new System.EventHandler(this.FactorialButton_Click);
            // 
            // InputNumberTextBox
            // 
            this.InputNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberTextBox.Location = new System.Drawing.Point(256, 100);
            this.InputNumberTextBox.Name = "InputNumberTextBox";
            this.InputNumberTextBox.Size = new System.Drawing.Size(224, 39);
            this.InputNumberTextBox.TabIndex = 9;
            this.InputNumberTextBox.TextChanged += new System.EventHandler(this.InputNumberTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Number";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "Factorial Finder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactorialFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 382);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FactorialButton);
            this.Controls.Add(this.InputNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FactorialFinder";
            this.Text = "FactorialFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FactorialButton;
        private System.Windows.Forms.TextBox InputNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}