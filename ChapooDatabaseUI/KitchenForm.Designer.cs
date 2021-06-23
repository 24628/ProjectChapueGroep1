
namespace ChapooDatabaseUI
{
    partial class KitchenForm : BaseForm
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
            this.AdministratorButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.KitchenButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.KitchenFormOrderFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.KitchenFormPickUpFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateTableStatusForm = new System.Windows.Forms.Button();
            this.LBL_OpenOrder = new System.Windows.Forms.Label();
            this.LBL_ReadyforPickup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            initNavBar();
            // 
            // KitchenFormOrderFlowLayout
            // 
            this.KitchenFormOrderFlowLayout.Location = new System.Drawing.Point(14, 186);
            this.KitchenFormOrderFlowLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KitchenFormOrderFlowLayout.Name = "KitchenFormOrderFlowLayout";
            this.KitchenFormOrderFlowLayout.Size = new System.Drawing.Size(1123, 205);
            this.KitchenFormOrderFlowLayout.TabIndex = 1;
            // 
            // KitchenFormPickUpFlowLayout
            // 
            this.KitchenFormPickUpFlowLayout.Location = new System.Drawing.Point(14, 477);
            this.KitchenFormPickUpFlowLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KitchenFormPickUpFlowLayout.Name = "KitchenFormPickUpFlowLayout";
            this.KitchenFormPickUpFlowLayout.Size = new System.Drawing.Size(1123, 205);
            this.KitchenFormPickUpFlowLayout.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1144, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(538, 632);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1353, 759);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // UpdateTableStatusForm
            // 
            this.UpdateTableStatusForm.Location = new System.Drawing.Point(1498, 759);
            this.UpdateTableStatusForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateTableStatusForm.Name = "UpdateTableStatusForm";
            this.UpdateTableStatusForm.Size = new System.Drawing.Size(184, 31);
            this.UpdateTableStatusForm.TabIndex = 4;
            this.UpdateTableStatusForm.Text = "Update Table Status";
            this.UpdateTableStatusForm.UseVisualStyleBackColor = true;
            this.UpdateTableStatusForm.Click += new System.EventHandler(this.UpdateTableStatusForm_Click);
            // 
            // LBL_OpenOrder
            // 
            this.LBL_OpenOrder.AutoSize = true;
            this.LBL_OpenOrder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_OpenOrder.Location = new System.Drawing.Point(14, 147);
            this.LBL_OpenOrder.Name = "LBL_OpenOrder";
            this.LBL_OpenOrder.Size = new System.Drawing.Size(180, 35);
            this.LBL_OpenOrder.TabIndex = 9;
            this.LBL_OpenOrder.Text = "Open Order(s):";
            // 
            // LBL_ReadyforPickup
            // 
            this.LBL_ReadyforPickup.AutoSize = true;
            this.LBL_ReadyforPickup.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_ReadyforPickup.Location = new System.Drawing.Point(12, 438);
            this.LBL_ReadyforPickup.Name = "LBL_ReadyforPickup";
            this.LBL_ReadyforPickup.Size = new System.Drawing.Size(206, 35);
            this.LBL_ReadyforPickup.TabIndex = 10;
            this.LBL_ReadyforPickup.Text = "Ready for Pickup:";
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1055);
            this.Controls.Add(this.LBL_ReadyforPickup);
            this.Controls.Add(this.LBL_OpenOrder);
            this.Controls.Add(this.UpdateTableStatusForm);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KitchenFormPickUpFlowLayout);
            this.Controls.Add(this.KitchenFormOrderFlowLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KitchenForm";
            this.Text = "Kitchen";
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void initNavBar()
        {
            // 
            // panel1
            // 
            this.NavBarContainer.Controls.Add(this.AdministratorButton);
            this.NavBarContainer.Controls.Add(this.OrderButton);
            this.NavBarContainer.Controls.Add(this.KitchenButton);
            this.NavBarContainer.Controls.Add(this.PaymentButton);
            //this.NavBarContainer.Controls.Add(this.KassaButton);
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
            this.KitchenButton.Text = "Kitchen and Bar";
            this.KitchenButton.UseVisualStyleBackColor = true;
            this.KitchenButton.Click += (sender, e) => KitchenButton(this);
            // 
            // ManagementButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(760, 0);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(250, 91);
            this.PaymentButton.TabIndex = 7;
            this.PaymentButton.Text = "Register";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += (sender, e) => PaymentButton(this);
            // 
            // KassaButton
            // 
            //this.KassaButton.Location = new System.Drawing.Point(662, 0);
            //this.KassaButton.Name = "KassaButton";
            //this.KassaButton.Size = new System.Drawing.Size(139, 51);
            //this.KassaButton.TabIndex = 6;
            //this.KassaButton.Text = "Kassa";
            //this.KassaButton.UseVisualStyleBackColor = true;
            //this.KassaButton.Click += (sender, e) => KassaButton(this);

            this.Controls.Add(this.NavBarContainer);
        }

        public void generateGridLayout(System.Windows.Forms.DataGridView view, string[] columnArr)
        {
            view.ColumnCount = columnArr.Length;

            view.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            view.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            view.GridColor = System.Drawing.Color.Black;
            view.RowHeadersVisible = false;
            view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            for (int i = 0; i < columnArr.Length; i++)
                view.Columns[i].Name = columnArr[i];

            view.MultiSelect = false;
        }

        public void FillDataInGridView(System.Windows.Forms.DataGridView view, string[] dataString)
        {
            view.Rows.Add(dataString);
        }

        public void ClearDataGridView(System.Windows.Forms.DataGridView view)
        {
            view.Columns.Clear();
        }

        #endregion

        private System.Windows.Forms.Panel NavBarContainer;
        private new System.Windows.Forms.Button AdministratorButton;
        private new System.Windows.Forms.Button OrderButton;
        private new System.Windows.Forms.Button KitchenButton;
        private new System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.FlowLayoutPanel KitchenFormOrderFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel KitchenFormPickUpFlowLayout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UpdateTableStatusForm;
        private System.Windows.Forms.Label LBL_OpenOrder;
        private System.Windows.Forms.Label LBL_ReadyforPickup;
    }
}