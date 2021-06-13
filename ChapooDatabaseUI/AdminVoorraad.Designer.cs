
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
            this.LBL_STStockID = new System.Windows.Forms.Label();
            this.TXTB_STStockIDs = new System.Windows.Forms.TextBox();
            this.TXTB_STMenuID = new System.Windows.Forms.Label();
            this.BTN_STUpdate = new System.Windows.Forms.Button();
            this.LBL_STAmount = new System.Windows.Forms.Label();
            this.BTN_STAdd = new System.Windows.Forms.Button();
            this.BTN_STDelete = new System.Windows.Forms.Button();
            this.TXTB_STMenuIDs = new System.Windows.Forms.TextBox();
            this.TXTB_STAmounts = new System.Windows.Forms.TextBox();
            this.BTN_STTerug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminVoorraadGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminVoorraadGrid
            // 
            this.AdminVoorraadGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminVoorraadGrid.Location = new System.Drawing.Point(130, 12);
            this.AdminVoorraadGrid.Name = "AdminVoorraadGrid";
            this.AdminVoorraadGrid.RowTemplate.Height = 25;
            this.AdminVoorraadGrid.Size = new System.Drawing.Size(481, 224);
            this.AdminVoorraadGrid.TabIndex = 0;
            // 
            // LBL_STStockID
            // 
            this.LBL_STStockID.AutoSize = true;
            this.LBL_STStockID.Location = new System.Drawing.Point(130, 243);
            this.LBL_STStockID.Name = "LBL_STStockID";
            this.LBL_STStockID.Size = new System.Drawing.Size(53, 15);
            this.LBL_STStockID.TabIndex = 1;
            this.LBL_STStockID.Text = "Stock ID:";
            // 
            // TXTB_STStockIDs
            // 
            this.TXTB_STStockIDs.Location = new System.Drawing.Point(130, 261);
            this.TXTB_STStockIDs.Name = "TXTB_STStockIDs";
            this.TXTB_STStockIDs.Size = new System.Drawing.Size(100, 23);
            this.TXTB_STStockIDs.TabIndex = 2;
            // 
            // TXTB_STMenuID
            // 
            this.TXTB_STMenuID.AutoSize = true;
            this.TXTB_STMenuID.Location = new System.Drawing.Point(130, 314);
            this.TXTB_STMenuID.Name = "TXTB_STMenuID";
            this.TXTB_STMenuID.Size = new System.Drawing.Size(55, 15);
            this.TXTB_STMenuID.TabIndex = 3;
            this.TXTB_STMenuID.Text = "Menu ID:";
            // 
            // BTN_STUpdate
            // 
            this.BTN_STUpdate.Location = new System.Drawing.Point(367, 242);
            this.BTN_STUpdate.Name = "BTN_STUpdate";
            this.BTN_STUpdate.Size = new System.Drawing.Size(94, 51);
            this.BTN_STUpdate.TabIndex = 4;
            this.BTN_STUpdate.Text = "Update";
            this.BTN_STUpdate.UseVisualStyleBackColor = true;
            this.BTN_STUpdate.Click += new System.EventHandler(this.BTN_STUpdate_Click);
            // 
            // LBL_STAmount
            // 
            this.LBL_STAmount.AutoSize = true;
            this.LBL_STAmount.Location = new System.Drawing.Point(130, 378);
            this.LBL_STAmount.Name = "LBL_STAmount";
            this.LBL_STAmount.Size = new System.Drawing.Size(51, 15);
            this.LBL_STAmount.TabIndex = 6;
            this.LBL_STAmount.Text = "Amount";
            // 
            // BTN_STAdd
            // 
            this.BTN_STAdd.Location = new System.Drawing.Point(367, 304);
            this.BTN_STAdd.Name = "BTN_STAdd";
            this.BTN_STAdd.Size = new System.Drawing.Size(94, 51);
            this.BTN_STAdd.TabIndex = 8;
            this.BTN_STAdd.Text = "Add";
            this.BTN_STAdd.UseVisualStyleBackColor = true;
            this.BTN_STAdd.Click += new System.EventHandler(this.BTN_STAdd_Click);
            // 
            // BTN_STDelete
            // 
            this.BTN_STDelete.Location = new System.Drawing.Point(367, 368);
            this.BTN_STDelete.Name = "BTN_STDelete";
            this.BTN_STDelete.Size = new System.Drawing.Size(94, 51);
            this.BTN_STDelete.TabIndex = 9;
            this.BTN_STDelete.Text = "Delete";
            this.BTN_STDelete.UseVisualStyleBackColor = true;
            this.BTN_STDelete.Click += new System.EventHandler(this.BTN_STDelete_Click);
            // 
            // TXTB_STMenuIDs
            // 
            this.TXTB_STMenuIDs.Location = new System.Drawing.Point(130, 332);
            this.TXTB_STMenuIDs.Name = "TXTB_STMenuIDs";
            this.TXTB_STMenuIDs.Size = new System.Drawing.Size(100, 23);
            this.TXTB_STMenuIDs.TabIndex = 10;
            // 
            // TXTB_STAmounts
            // 
            this.TXTB_STAmounts.Location = new System.Drawing.Point(130, 396);
            this.TXTB_STAmounts.Name = "TXTB_STAmounts";
            this.TXTB_STAmounts.Size = new System.Drawing.Size(100, 23);
            this.TXTB_STAmounts.TabIndex = 11;
            // 
            // BTN_STTerug
            // 
            this.BTN_STTerug.Location = new System.Drawing.Point(12, 12);
            this.BTN_STTerug.Name = "BTN_STTerug";
            this.BTN_STTerug.Size = new System.Drawing.Size(57, 37);
            this.BTN_STTerug.TabIndex = 19;
            this.BTN_STTerug.Text = "Terug";
            this.BTN_STTerug.UseVisualStyleBackColor = true;
            this.BTN_STTerug.Click += new System.EventHandler(this.BTN_STTerug_Click);
            // 
            // AdminVoorraad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_STTerug);
            this.Controls.Add(this.TXTB_STAmounts);
            this.Controls.Add(this.TXTB_STMenuIDs);
            this.Controls.Add(this.BTN_STDelete);
            this.Controls.Add(this.BTN_STAdd);
            this.Controls.Add(this.LBL_STAmount);
            this.Controls.Add(this.BTN_STUpdate);
            this.Controls.Add(this.TXTB_STMenuID);
            this.Controls.Add(this.TXTB_STStockIDs);
            this.Controls.Add(this.LBL_STStockID);
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
        private System.Windows.Forms.Label LBL_STStockID;
        private System.Windows.Forms.TextBox TXTB_STStockIDs;
        private System.Windows.Forms.Label TXTB_STMenuID;
        private System.Windows.Forms.Button BTN_STUpdate;
        private System.Windows.Forms.Label LBL_STAmount;
        private System.Windows.Forms.Button BTN_STAdd;
        private System.Windows.Forms.Button BTN_STDelete;
        private System.Windows.Forms.TextBox TXTB_STMenuIDs;
        private System.Windows.Forms.TextBox TXTB_STAmounts;
        private System.Windows.Forms.Button BTN_STTerug;
    }
}