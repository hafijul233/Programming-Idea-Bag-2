namespace _003FactorialFinderApp
{
    partial class FactorialFinderUi
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
            this.label2 = new System.Windows.Forms.Label();
            this.InputNumberTextBox = new System.Windows.Forms.TextBox();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factorial Finder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Number";
            // 
            // InputNumberTextBox
            // 
            this.InputNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberTextBox.Location = new System.Drawing.Point(256, 87);
            this.InputNumberTextBox.Name = "InputNumberTextBox";
            this.InputNumberTextBox.Size = new System.Drawing.Size(224, 39);
            this.InputNumberTextBox.TabIndex = 2;
            this.InputNumberTextBox.TextChanged += new System.EventHandler(this.InputNumberTextBox_TextChanged);
            // 
            // FactorialButton
            // 
            this.FactorialButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FactorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactorialButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FactorialButton.Location = new System.Drawing.Point(140, 273);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(244, 84);
            this.FactorialButton.TabIndex = 3;
            this.FactorialButton.Text = "Factorial";
            this.FactorialButton.UseVisualStyleBackColor = false;
            this.FactorialButton.Click += new System.EventHandler(this.FactorialButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Factorial Value:";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.Location = new System.Drawing.Point(17, 210);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(508, 39);
            this.OutputTextBox.TabIndex = 6;
            // 
            // FactorialFinderUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 382);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FactorialButton);
            this.Controls.Add(this.InputNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FactorialFinderUi";
            this.Text = "Factorial Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FactorialFinderUi_FormClosing);
            this.Load += new System.EventHandler(this.FactorialFinderUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputNumberTextBox;
        private System.Windows.Forms.Button FactorialButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

