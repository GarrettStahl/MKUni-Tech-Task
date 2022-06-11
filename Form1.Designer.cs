
namespace MKUniProgTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InstructTextBox = new System.Windows.Forms.TextBox();
            this.MultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserInText
            // 
            this.UserInText.Location = new System.Drawing.Point(554, 265);
            this.UserInText.Name = "UserInText";
            this.UserInText.Size = new System.Drawing.Size(68, 23);
            this.UserInText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Produce points";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstructTextBox
            // 
            this.InstructTextBox.Location = new System.Drawing.Point(430, 236);
            this.InstructTextBox.Name = "InstructTextBox";
            this.InstructTextBox.ReadOnly = true;
            this.InstructTextBox.Size = new System.Drawing.Size(336, 23);
            this.InstructTextBox.TabIndex = 2;
            this.InstructTextBox.Text = "Enter number of points to test (must be a multiple of 8 + 1).";
            this.InstructTextBox.TextChanged += new System.EventHandler(this.InstructTextBox_TextChanged);
            // 
            // MultTextBox
            // 
            this.MultTextBox.AcceptsReturn = true;
            this.MultTextBox.AcceptsTab = true;
            this.MultTextBox.Location = new System.Drawing.Point(12, 571);
            this.MultTextBox.Multiline = true;
            this.MultTextBox.Name = "MultTextBox";
            this.MultTextBox.ReadOnly = true;
            this.MultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MultTextBox.Size = new System.Drawing.Size(1150, 102);
            this.MultTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 685);
            this.Controls.Add(this.MultTextBox);
            this.Controls.Add(this.InstructTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserInText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InstructTextBox;
        private System.Windows.Forms.TextBox MultTextBox;
    }
}

