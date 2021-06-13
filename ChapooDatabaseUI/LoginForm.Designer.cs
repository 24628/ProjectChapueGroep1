
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
            this.LoginFormEmailTextBox.Location = new System.Drawing.Point(284, 267);
            this.LoginFormEmailTextBox.Name = "LoginFormEmailTextBox";
            this.LoginFormEmailTextBox.Size = new System.Drawing.Size(260, 27);
            this.LoginFormEmailTextBox.TabIndex = 0;
            // 
            // LoginFormPasswordTextBox
            // 
            this.LoginFormPasswordTextBox.Location = new System.Drawing.Point(284, 328);
            this.LoginFormPasswordTextBox.Name = "LoginFormPasswordTextBox";
            this.LoginFormPasswordTextBox.PasswordChar = '*';
            this.LoginFormPasswordTextBox.Size = new System.Drawing.Size(260, 27);
            this.LoginFormPasswordTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginFormSubmitButton_Click);
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Location = new System.Drawing.Point(192, 270);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(55, 20);
            this.LBL_Email.TabIndex = 3;
            this.LBL_Email.Text = "E-mail:";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Location = new System.Drawing.Point(192, 331);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(73, 20);
            this.LBL_Password.TabIndex = 4;
            this.LBL_Password.Text = "Password:";
            // 
            // pBX_ChapeauLogo
            // 
            this.pBX_ChapeauLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBX_ChapeauLogo.Image")));
            this.pBX_ChapeauLogo.Location = new System.Drawing.Point(224, 12);
            this.pBX_ChapeauLogo.Name = "pBX_ChapeauLogo";
            this.pBX_ChapeauLogo.Size = new System.Drawing.Size(355, 191);
            this.pBX_ChapeauLogo.TabIndex = 5;
            this.pBX_ChapeauLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBX_ChapeauLogo);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_Email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginFormPasswordTextBox);
            this.Controls.Add(this.LoginFormEmailTextBox);
            this.Name = "LoginForm";
            this.Text = "Form1";
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

