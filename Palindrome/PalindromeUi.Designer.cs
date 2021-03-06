﻿namespace Palindrome
{
    partial class PalindromeUi
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
            this.ReplyLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.InputStringTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palindrome Checker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReplyLabel
            // 
            this.ReplyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyLabel.Location = new System.Drawing.Point(0, 335);
            this.ReplyLabel.Name = "ReplyLabel";
            this.ReplyLabel.Size = new System.Drawing.Size(800, 65);
            this.ReplyLabel.TabIndex = 15;
            this.ReplyLabel.Text = "Result";
            this.ReplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckButton.Location = new System.Drawing.Point(259, 215);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(244, 71);
            this.CheckButton.TabIndex = 14;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // InputStringTextBox
            // 
            this.InputStringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStringTextBox.Location = new System.Drawing.Point(8, 153);
            this.InputStringTextBox.Name = "InputStringTextBox";
            this.InputStringTextBox.Size = new System.Drawing.Size(780, 39);
            this.InputStringTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Text/String to Check is it\'s Palindrome ?";
            // 
            // PalindromeUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.ReplyLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.InputStringTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PalindromeUi";
            this.Text = "Text Palindrome Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReplyLabel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox InputStringTextBox;
        private System.Windows.Forms.Label label2;
    }
}

