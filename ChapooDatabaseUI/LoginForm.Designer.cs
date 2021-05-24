
namespace ChapooUI
{
    partial class LoginForm
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
            this.LoginFormEmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormPasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginFormEmailTextBox
            // 
            this.LoginFormEmailTextBox.Location = new System.Drawing.Point(359, 128);
            this.LoginFormEmailTextBox.Name = "LoginFormEmailTextBox";
            this.LoginFormEmailTextBox.Size = new System.Drawing.Size(260, 27);
            this.LoginFormEmailTextBox.TabIndex = 0;
            // 
            // LoginFormPasswordTextBox
            // 
            this.LoginFormPasswordTextBox.Location = new System.Drawing.Point(359, 189);
            this.LoginFormPasswordTextBox.Name = "LoginFormPasswordTextBox";
            this.LoginFormPasswordTextBox.Size = new System.Drawing.Size(260, 27);
            this.LoginFormPasswordTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginFormSubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginFormPasswordTextBox);
            this.Controls.Add(this.LoginFormEmailTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginFormEmailTextBox;
        private System.Windows.Forms.TextBox LoginFormPasswordTextBox;
        private System.Windows.Forms.Button button1;
    }
}

