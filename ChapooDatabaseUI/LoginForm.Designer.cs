
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginFormEmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormPasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.pBX_ChapeauLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBX_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginFormEmailTextBox
            // 
            this.LoginFormEmailTextBox.Location = new System.Drawing.Point(248, 200);
            this.LoginFormEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginFormEmailTextBox.Name = "LoginFormEmailTextBox";
            this.LoginFormEmailTextBox.Size = new System.Drawing.Size(228, 23);
            this.LoginFormEmailTextBox.TabIndex = 0;
            // 
            // LoginFormPasswordTextBox
            // 
            this.LoginFormPasswordTextBox.Location = new System.Drawing.Point(248, 246);
            this.LoginFormPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginFormPasswordTextBox.Name = "LoginFormPasswordTextBox";
            this.LoginFormPasswordTextBox.PasswordChar = '*';
            this.LoginFormPasswordTextBox.Size = new System.Drawing.Size(228, 23);
            this.LoginFormPasswordTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginFormSubmitButton_Click);
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Location = new System.Drawing.Point(168, 202);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(44, 15);
            this.LBL_Email.TabIndex = 3;
            this.LBL_Email.Text = "E-mail:";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Location = new System.Drawing.Point(168, 248);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(60, 15);
            this.LBL_Password.TabIndex = 4;
            this.LBL_Password.Text = "Password:";
            // 
            // pBX_ChapeauLogo
            // 
            this.pBX_ChapeauLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBX_ChapeauLogo.Image")));
            this.pBX_ChapeauLogo.Location = new System.Drawing.Point(196, 9);
            this.pBX_ChapeauLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBX_ChapeauLogo.Name = "pBX_ChapeauLogo";
            this.pBX_ChapeauLogo.Size = new System.Drawing.Size(359, 187);
            this.pBX_ChapeauLogo.TabIndex = 5;
            this.pBX_ChapeauLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pBX_ChapeauLogo);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_Email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginFormPasswordTextBox);
            this.Controls.Add(this.LoginFormEmailTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pBX_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginFormEmailTextBox;
        private System.Windows.Forms.TextBox LoginFormPasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.PictureBox pBX_ChapeauLogo;
    }
}

