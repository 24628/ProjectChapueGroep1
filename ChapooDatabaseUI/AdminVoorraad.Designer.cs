
namespace ChapooDatabaseUI
{
    partial class AdminVoorraad
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
            this.AdminVoorraadGrid = new System.Windows.Forms.DataGridView();
            this.BTN_STUpdate = new System.Windows.Forms.Button();
            this.TXTB_STAmounts = new System.Windows.Forms.TextBox();
            this.BTN_STTerug = new System.Windows.Forms.Button();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminVoorraadGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminVoorraadGrid
            // 
            this.AdminVoorraadGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminVoorraadGrid.Location = new System.Drawing.Point(12, 12);
            this.AdminVoorraadGrid.Name = "AdminVoorraadGrid";
            this.AdminVoorraadGrid.RowHeadersWidth = 51;
            this.AdminVoorraadGrid.RowTemplate.Height = 25;
            this.AdminVoorraadGrid.Size = new System.Drawing.Size(978, 526);
            this.AdminVoorraadGrid.TabIndex = 0;
            this.AdminVoorraadGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminVoorraadGrid_CellContentClick);
            // 
            // BTN_STUpdate
            // 
            this.BTN_STUpdate.Location = new System.Drawing.Point(741, 543);
            this.BTN_STUpdate.Name = "BTN_STUpdate";
            this.BTN_STUpdate.Size = new System.Drawing.Size(249, 52);
            this.BTN_STUpdate.TabIndex = 4;
            this.BTN_STUpdate.Text = "Update";
            this.BTN_STUpdate.UseVisualStyleBackColor = true;
            this.BTN_STUpdate.Click += new System.EventHandler(this.BTN_STUpdate_Click);
            // 
            // TXTB_STAmounts
            // 
            this.TXTB_STAmounts.Location = new System.Drawing.Point(12, 543);
            this.TXTB_STAmounts.Name = "TXTB_STAmounts";
            this.TXTB_STAmounts.PlaceholderText = "Amount";
            this.TXTB_STAmounts.Size = new System.Drawing.Size(272, 23);
            this.TXTB_STAmounts.TabIndex = 11;
            // 
            // BTN_STTerug
            // 
            this.BTN_STTerug.Location = new System.Drawing.Point(994, 12);
            this.BTN_STTerug.Name = "BTN_STTerug";
            this.BTN_STTerug.Size = new System.Drawing.Size(89, 38);
            this.BTN_STTerug.TabIndex = 19;
            this.BTN_STTerug.Text = "Terug";
            this.BTN_STTerug.UseVisualStyleBackColor = true;
            this.BTN_STTerug.Click += new System.EventHandler(this.BTN_STTerug_Click);
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Location = new System.Drawing.Point(12, 543);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.PlaceholderText = "Amount";
            this.TextBoxAmount.Size = new System.Drawing.Size(272, 23);
            this.TextBoxAmount.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(994, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 54);
            this.button4.TabIndex = 19;
            this.button4.Text = "Terug";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BTN_STTerug_Click);
            // 
            // AdminVoorraad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 758);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.BTN_STTerug);
            this.Controls.Add(this.TXTB_STAmounts);
            this.Controls.Add(this.BTN_STUpdate);
            this.Controls.Add(this.AdminVoorraadGrid);
            this.Name = "AdminVoorraad";
            this.Text = "AdminVoorraad";
            ((System.ComponentModel.ISupportInitialize)(this.AdminVoorraadGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void generateGridLayout(System.Windows.Forms.DataGridView view, string[] columnArr)
        {
            view.ColumnCount = columnArr.Length;

            view.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            view.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            view.GridColor = System.Drawing.Color.Black;
            view.RowHeadersVisible = false;
            view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

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

        private System.Windows.Forms.DataGridView AdminVoorraadGrid;
        private System.Windows.Forms.Button BTN_STUpdate;
        private System.Windows.Forms.TextBox TXTB_STAmounts;
        private System.Windows.Forms.Button BTN_STTerug;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Button button4;
    }
}