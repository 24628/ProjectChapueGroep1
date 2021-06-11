
namespace ChapooDatabaseUI
{
    partial class PaymentForm
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
            this.TableHolderFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priceLabelPayment = new System.Windows.Forms.Label();
            this.SubmitReceedBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.initNavBar();
            // 
            // TableHolderFlowLayout
            // 
            this.TableHolderFlowLayout.Location = new System.Drawing.Point(12, 188);
            this.TableHolderFlowLayout.Name = "TableHolderFlowLayout";
            this.TableHolderFlowLayout.Size = new System.Drawing.Size(718, 460);
            this.TableHolderFlowLayout.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(736, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(490, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // priceLabelPayment
            // 
            this.priceLabelPayment.AutoSize = true;
            this.priceLabelPayment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabelPayment.Location = new System.Drawing.Point(736, 651);
            this.priceLabelPayment.Name = "priceLabelPayment";
            this.priceLabelPayment.Size = new System.Drawing.Size(105, 28);
            this.priceLabelPayment.TabIndex = 1;
            this.priceLabelPayment.Text = "Total Price:";
            // 
            // SubmitReceedBTN
            // 
            this.SubmitReceedBTN.Location = new System.Drawing.Point(1064, 658);
            this.SubmitReceedBTN.Name = "SubmitReceedBTN";
            this.SubmitReceedBTN.Size = new System.Drawing.Size(162, 21);
            this.SubmitReceedBTN.TabIndex = 2;
            this.SubmitReceedBTN.Text = "Submit receed";
            this.SubmitReceedBTN.UseVisualStyleBackColor = true;
            this.SubmitReceedBTN.Click += new System.EventHandler(this.SubmitReceedBTN_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 819);
            this.Controls.Add(this.SubmitReceedBTN);
            this.Controls.Add(this.priceLabelPayment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TableHolderFlowLayout);
            this.Name = "PaymentForm";
            this.Text = "Payment";
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
            this.NavBarContainer.Size = new System.Drawing.Size(801, 51);
            this.NavBarContainer.TabIndex = 2;
            // 
            // BarMederwerkesButton
            // 
            this.AdministratorButton.Location = new System.Drawing.Point(82, 0);
            this.AdministratorButton.Name = "AdministratorButton";
            this.AdministratorButton.Size = new System.Drawing.Size(139, 51);
            this.AdministratorButton.TabIndex = 10;
            this.AdministratorButton.Text = "Administrator";
            this.AdministratorButton.UseVisualStyleBackColor = true;
            this.AdministratorButton.Click += (sender, e) => AdministratorButton(this);
            // 
            // BedieningButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(227, 0);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(139, 51);
            this.OrderButton.TabIndex = 9;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += (sender, e) => OrderButton(this);
            // 
            // ChefKokButton
            // 
            this.KitchenButton.Location = new System.Drawing.Point(372, 0);
            this.KitchenButton.Name = "KitchenButton";
            this.KitchenButton.Size = new System.Drawing.Size(139, 51);
            this.KitchenButton.TabIndex = 8;
            this.KitchenButton.Text = "Kitchen";
            this.KitchenButton.UseVisualStyleBackColor = true;
            this.KitchenButton.Click += (sender, e) => KitchenButton(this);
            // 
            // ManagementButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(517, 0);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(139, 51);
            this.PaymentButton.TabIndex = 7;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += (sender, e) => PaymentButton(this);
            // 
            // KassaButton
            // 


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
        private System.Windows.Forms.FlowLayoutPanel TableHolderFlowLayout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label priceLabelPayment;
        private System.Windows.Forms.Button SubmitReceedBTN;
    }
}