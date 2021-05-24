
namespace ChapooDatabaseUI
{
    partial class ChefForm
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
            this.NavBarContainer = new System.Windows.Forms.Panel();
            this.BarMederwerkesButton = new System.Windows.Forms.Button();
            this.BedieningButton = new System.Windows.Forms.Button();
            this.ChefKokButton = new System.Windows.Forms.Button();
            this.ManagementButton = new System.Windows.Forms.Button();
            this.KassaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Chef";
            this.Name = "ChefForm";
            this.ResumeLayout(false);

            initNavBar();

        }

        public void initNavBar()
        {
            // 
            // panel1
            // 
            this.NavBarContainer.Controls.Add(this.BarMederwerkesButton);
            this.NavBarContainer.Controls.Add(this.BedieningButton);
            this.NavBarContainer.Controls.Add(this.ChefKokButton);
            this.NavBarContainer.Controls.Add(this.ManagementButton);
            this.NavBarContainer.Controls.Add(this.KassaButton);
            this.NavBarContainer.Location = new System.Drawing.Point(0, 0);
            this.NavBarContainer.Name = "NavBarContainer";
            this.NavBarContainer.Size = new System.Drawing.Size(801, 51);
            this.NavBarContainer.TabIndex = 2;
            // 
            // BarMederwerkesButton
            // 
            this.BarMederwerkesButton.Location = new System.Drawing.Point(82, 0);
            this.BarMederwerkesButton.Name = "BarMederwerkesButton";
            this.BarMederwerkesButton.Size = new System.Drawing.Size(139, 51);
            this.BarMederwerkesButton.TabIndex = 10;
            this.BarMederwerkesButton.Text = "Bar Mederwerkes";
            this.BarMederwerkesButton.UseVisualStyleBackColor = true;
            this.BarMederwerkesButton.Click += (sender, e) => BarEmployeeButton(this);
            // 
            // BedieningButton
            // 
            this.BedieningButton.Location = new System.Drawing.Point(227, 0);
            this.BedieningButton.Name = "BedieningButton";
            this.BedieningButton.Size = new System.Drawing.Size(139, 51);
            this.BedieningButton.TabIndex = 9;
            this.BedieningButton.Text = "Bediening";
            this.BedieningButton.UseVisualStyleBackColor = true;
            this.BedieningButton.Click += (sender, e) => BarSericeButton(this);
            // 
            // ChefKokButton
            // 
            this.ChefKokButton.Location = new System.Drawing.Point(372, 0);
            this.ChefKokButton.Name = "ChefKokButton";
            this.ChefKokButton.Size = new System.Drawing.Size(139, 51);
            this.ChefKokButton.TabIndex = 8;
            this.ChefKokButton.Text = "Chefkok";
            this.ChefKokButton.UseVisualStyleBackColor = true;
            this.ChefKokButton.Click += (sender, e) => ChefButton(this);
            // 
            // ManagementButton
            // 
            this.ManagementButton.Location = new System.Drawing.Point(517, 0);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(139, 51);
            this.ManagementButton.TabIndex = 7;
            this.ManagementButton.Text = "Managament";
            this.ManagementButton.UseVisualStyleBackColor = true;
            this.ManagementButton.Click += (sender, e) => ManagementButton(this);
            // 
            // KassaButton
            // 
            this.KassaButton.Location = new System.Drawing.Point(662, 0);
            this.KassaButton.Name = "KassaButton";
            this.KassaButton.Size = new System.Drawing.Size(139, 51);
            this.KassaButton.TabIndex = 6;
            this.KassaButton.Text = "Kassa";
            this.KassaButton.UseVisualStyleBackColor = true;
            this.KassaButton.Click += (sender, e) => KassaButton(this);

            this.Controls.Add(this.NavBarContainer);
        }

        #endregion

        private System.Windows.Forms.Panel NavBarContainer;
        private System.Windows.Forms.Button BarMederwerkesButton;
        private System.Windows.Forms.Button BedieningButton;
        private System.Windows.Forms.Button ChefKokButton;
        private new System.Windows.Forms.Button ManagementButton;
        private new System.Windows.Forms.Button KassaButton;

    }
}