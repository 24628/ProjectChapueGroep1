
namespace ChapooUI
{
    partial class LoginForm
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
            this.LoginFormSubmitButton = new System.Windows.Forms.Button();
            this.LoginFormEmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginFormSubmitButton
            // 
            this.LoginFormSubmitButton.Location = new System.Drawing.Point(432, 249);
            this.LoginFormSubmitButton.Name = "LoginFormSubmitButton";
            this.LoginFormSubmitButton.Size = new System.Drawing.Size(122, 34);
            this.LoginFormSubmitButton.TabIndex = 0;
            this.LoginFormSubmitButton.Text = "Submit";
            this.LoginFormSubmitButton.UseVisualStyleBackColor = true;
            this.LoginFormSubmitButton.Click += new System.EventHandler(this.LoginFormSubmitButton_Click);
            // 
            // LoginFormEmailTextBox
            // 
            this.LoginFormEmailTextBox.Location = new System.Drawing.Point(187, 123);
            this.LoginFormEmailTextBox.Name = "LoginFormEmailTextBox";
            this.LoginFormEmailTextBox.Size = new System.Drawing.Size(367, 20);
            this.LoginFormEmailTextBox.TabIndex = 1;
            // 
            // LoginFormPasswordTextBox
            // 
            this.LoginFormPasswordTextBox.Location = new System.Drawing.Point(187, 184);
            this.LoginFormPasswordTextBox.Name = "LoginFormPasswordTextBox";
            this.LoginFormPasswordTextBox.Size = new System.Drawing.Size(367, 20);
            this.LoginFormPasswordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginFormPasswordTextBox);
            this.Controls.Add(this.LoginFormEmailTextBox);
            this.Controls.Add(this.LoginFormSubmitButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginFormSubmitButton;
        private System.Windows.Forms.TextBox LoginFormEmailTextBox;
        private System.Windows.Forms.TextBox LoginFormPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}