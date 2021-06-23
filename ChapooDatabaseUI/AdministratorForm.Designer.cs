
namespace ChapooDatabaseUI
{
    partial class AdministratorForm : BaseForm
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
            this.BTN_Werknemers = new System.Windows.Forms.Button();
            this.BTN_MenuItem = new System.Windows.Forms.Button();
            this.BTN_Voorraad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            initNavBar();
            // 
            // BTN_Werknemers
            // 
            this.BTN_Werknemers.Location = new System.Drawing.Point(817, 435);
            this.BTN_Werknemers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Werknemers.Name = "BTN_Werknemers";
            this.BTN_Werknemers.Size = new System.Drawing.Size(288, 203);
            this.BTN_Werknemers.TabIndex = 29;
            this.BTN_Werknemers.Text = "Werknemers";
            this.BTN_Werknemers.UseVisualStyleBackColor = true;
            this.BTN_Werknemers.Click += new System.EventHandler(this.BTN_Werknemers_Click);
            // 
            // BTN_MenuItem
            // 
            this.BTN_MenuItem.Location = new System.Drawing.Point(413, 435);
            this.BTN_MenuItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_MenuItem.Name = "BTN_MenuItem";
            this.BTN_MenuItem.Size = new System.Drawing.Size(288, 203);
            this.BTN_MenuItem.TabIndex = 30;
            this.BTN_MenuItem.Text = "Menu Items";
            this.BTN_MenuItem.UseVisualStyleBackColor = true;
            this.BTN_MenuItem.Click += new System.EventHandler(this.BTN_MenuItem_Click);
            // 
            // BTN_Voorraad
            // 
            this.BTN_Voorraad.Location = new System.Drawing.Point(1216, 435);
            this.BTN_Voorraad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Voorraad.Name = "BTN_Voorraad";
            this.BTN_Voorraad.Size = new System.Drawing.Size(288, 203);
            this.BTN_Voorraad.TabIndex = 31;
            this.BTN_Voorraad.Text = "Voorraad";
            this.BTN_Voorraad.UseVisualStyleBackColor = true;
            this.BTN_Voorraad.Click += new System.EventHandler(this.BTN_Voorraad_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 824);
            this.Controls.Add(this.BTN_Voorraad);
            this.Controls.Add(this.BTN_MenuItem);
            this.Controls.Add(this.BTN_Werknemers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministratorForm";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        public void initNavBar()
        {
            this.NavBarContainer = new System.Windows.Forms.Panel();
            this.AdministratorButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.KitchenButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.NavBarContainer.Controls.Add(this.AdministratorButton);
            this.NavBarContainer.Controls.Add(this.OrderButton);
            this.NavBarContainer.Controls.Add(this.KitchenButton);
            this.NavBarContainer.Controls.Add(this.PaymentButton);
            this.NavBarContainer.Location = new System.Drawing.Point(0, 0);
            this.NavBarContainer.Name = "NavBarContainer";
            this.NavBarContainer.Size = new System.Drawing.Size(1801, 100);
            this.NavBarContainer.TabIndex = 2;
            // 
            // AdministratorButton
            // 
            this.AdministratorButton.Location = new System.Drawing.Point(10, 0);
            this.AdministratorButton.Name = "AdministratorButton";
            this.AdministratorButton.Size = new System.Drawing.Size(250, 91);
            this.AdministratorButton.TabIndex = 10;
            this.AdministratorButton.Text = "Administrator";
            this.AdministratorButton.UseVisualStyleBackColor = true;
            this.AdministratorButton.Click += (sender, e) => AdministratorButton(this);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(260, 0);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(250, 91);
            this.OrderButton.TabIndex = 9;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += (sender, e) => OrderButton(this);
            // 
            // KitchenButton
            // 
            this.KitchenButton.Location = new System.Drawing.Point(510, 0);
            this.KitchenButton.Name = "KitchenButton";
            this.KitchenButton.Size = new System.Drawing.Size(250, 91);
            this.KitchenButton.TabIndex = 8;
            this.KitchenButton.Text = "Kitchen en Bar";
            this.KitchenButton.UseVisualStyleBackColor = true;
            this.KitchenButton.Click += (sender, e) => KitchenButton(this);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(760, 0);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(250, 91);
            this.PaymentButton.TabIndex = 7;
            this.PaymentButton.Text = "Register";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += (sender, e) => PaymentButton(this);

            this.Controls.Add(this.NavBarContainer);
        }

        #endregion
        private System.Windows.Forms.Panel NavBarContainer;
        private new System.Windows.Forms.Button AdministratorButton;
        private new System.Windows.Forms.Button OrderButton;
        private new System.Windows.Forms.Button KitchenButton;
        private new System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button BTN_Werknemers;
        private System.Windows.Forms.Button BTN_MenuItem;
        private System.Windows.Forms.Button BTN_Voorraad;
    }
}