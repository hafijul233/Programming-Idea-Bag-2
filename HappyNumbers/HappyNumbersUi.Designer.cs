namespace _004HappyNumbers
{
    partial class HappyNumbersUi
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
            this.CheckButton = new System.Windows.Forms.Button();
            this.InputNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckButton.Location = new System.Drawing.Point(112, 200);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(244, 84);
            this.CheckButton.TabIndex = 10;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // InputNumberTextBox
            // 
            this.InputNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberTextBox.Location = new System.Drawing.Point(54, 135);
            this.InputNumberTextBox.Name = "InputNumberTextBox";
            this.InputNumberTextBox.Size = new System.Drawing.Size(388, 39);
            this.InputNumberTextBox.TabIndex = 9;
            this.InputNumberTextBox.TextChanged += new System.EventHandler(this.InputNumberTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Number to Check is it\'s Happy ?";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "Happy Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReplyLabel
            // 
            this.ReplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyLabel.Location = new System.Drawing.Point(-1, 305);
            this.ReplyLabel.Name = "ReplyLabel";
            this.ReplyLabel.Size = new System.Drawing.Size(513, 65);
            this.ReplyLabel.TabIndex = 11;
            this.ReplyLabel.Text = "0";
            this.ReplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HappyNumbersUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 379);
            this.Controls.Add(this.ReplyLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.InputNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HappyNumbersUi";
            this.Text = "Happy Numbers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HappyNumbersUi_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox InputNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReplyLabel;
    }
}

