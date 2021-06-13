
namespace ChapooDatabaseUI
{
    partial class AdminMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminMenuGrid = new System.Windows.Forms.DataGridView();
            this.TXTB_MIMenuItemID = new System.Windows.Forms.TextBox();
            this.TXTB_MIMenuName = new System.Windows.Forms.TextBox();
            this.TXTB_MIMenuID = new System.Windows.Forms.TextBox();
            this.TXTB_MIPrice = new System.Windows.Forms.TextBox();
            this.BTN_MIMenuAdd = new System.Windows.Forms.Button();
            this.BTN_MIMenuUpdate = new System.Windows.Forms.Button();
            this.BTN_MIDelete = new System.Windows.Forms.Button();
            this.MenuTypesGrid = new System.Windows.Forms.DataGridView();
            this.BTN_MITerug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTypesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminMenuGrid
            // 
            this.AdminMenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminMenuGrid.Location = new System.Drawing.Point(132, 15);
            this.AdminMenuGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminMenuGrid.Name = "AdminMenuGrid";
            this.AdminMenuGrid.RowHeadersWidth = 51;
            this.AdminMenuGrid.RowTemplate.Height = 25;
            this.AdminMenuGrid.Size = new System.Drawing.Size(587, 349);
            this.AdminMenuGrid.TabIndex = 0;
            // 
            // TXTB_MIMenuItemID
            // 
            this.TXTB_MIMenuItemID.Location = new System.Drawing.Point(275, 384);
            this.TXTB_MIMenuItemID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_MIMenuItemID.Name = "TXTB_MIMenuItemID";
            this.TXTB_MIMenuItemID.PlaceholderText = "Item ID";
            this.TXTB_MIMenuItemID.Size = new System.Drawing.Size(114, 27);
            this.TXTB_MIMenuItemID.TabIndex = 2;
            // 
            // TXTB_MIMenuName
            // 
            this.TXTB_MIMenuName.Location = new System.Drawing.Point(416, 384);
            this.TXTB_MIMenuName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_MIMenuName.Name = "TXTB_MIMenuName";
            this.TXTB_MIMenuName.PlaceholderText = "Menu Name";
            this.TXTB_MIMenuName.Size = new System.Drawing.Size(114, 27);
            this.TXTB_MIMenuName.TabIndex = 4;
            // 
            // TXTB_MIMenuID
            // 
            this.TXTB_MIMenuID.Location = new System.Drawing.Point(132, 384);
            this.TXTB_MIMenuID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_MIMenuID.Name = "TXTB_MIMenuID";
            this.TXTB_MIMenuID.PlaceholderText = "Menu ID";
            this.TXTB_MIMenuID.Size = new System.Drawing.Size(114, 27);
            this.TXTB_MIMenuID.TabIndex = 7;
            // 
            // TXTB_MIPrice
            // 
            this.TXTB_MIPrice.Location = new System.Drawing.Point(560, 384);
            this.TXTB_MIPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_MIPrice.Name = "TXTB_MIPrice";
            this.TXTB_MIPrice.PlaceholderText = "Price";
            this.TXTB_MIPrice.Size = new System.Drawing.Size(114, 27);
            this.TXTB_MIPrice.TabIndex = 8;
            // 
            // BTN_MIMenuAdd
            // 
            this.BTN_MIMenuAdd.Location = new System.Drawing.Point(202, 450);
            this.BTN_MIMenuAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_MIMenuAdd.Name = "BTN_MIMenuAdd";
            this.BTN_MIMenuAdd.Size = new System.Drawing.Size(104, 55);
            this.BTN_MIMenuAdd.TabIndex = 9;
            this.BTN_MIMenuAdd.Text = "Add";
            this.BTN_MIMenuAdd.UseVisualStyleBackColor = true;
            this.BTN_MIMenuAdd.Click += new System.EventHandler(this.BTN_MIMenuAdd_Click);
            // 
            // BTN_MIMenuUpdate
            // 
            this.BTN_MIMenuUpdate.Location = new System.Drawing.Point(349, 449);
            this.BTN_MIMenuUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_MIMenuUpdate.Name = "BTN_MIMenuUpdate";
            this.BTN_MIMenuUpdate.Size = new System.Drawing.Size(104, 56);
            this.BTN_MIMenuUpdate.TabIndex = 10;
            this.BTN_MIMenuUpdate.Text = "Update";
            this.BTN_MIMenuUpdate.UseVisualStyleBackColor = true;
            this.BTN_MIMenuUpdate.Click += new System.EventHandler(this.BTN_MIMenuUpdate_Click);
            // 
            // BTN_MIDelete
            // 
            this.BTN_MIDelete.Location = new System.Drawing.Point(495, 450);
            this.BTN_MIDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_MIDelete.Name = "BTN_MIDelete";
            this.BTN_MIDelete.Size = new System.Drawing.Size(104, 55);
            this.BTN_MIDelete.TabIndex = 11;
            this.BTN_MIDelete.Text = "Delete";
            this.BTN_MIDelete.UseVisualStyleBackColor = true;
            this.BTN_MIDelete.Click += new System.EventHandler(this.BTN_MIDelete_Click);
            // 
            // MenuTypesGrid
            // 
            this.MenuTypesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuTypesGrid.Location = new System.Drawing.Point(726, 15);
            this.MenuTypesGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuTypesGrid.Name = "MenuTypesGrid";
            this.MenuTypesGrid.RowHeadersWidth = 51;
            this.MenuTypesGrid.RowTemplate.Height = 25;
            this.MenuTypesGrid.Size = new System.Drawing.Size(405, 349);
            this.MenuTypesGrid.TabIndex = 12;
            // 
            // BTN_MITerug
            // 
            this.BTN_MITerug.Location = new System.Drawing.Point(12, 15);
            this.BTN_MITerug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_MITerug.Name = "BTN_MITerug";
            this.BTN_MITerug.Size = new System.Drawing.Size(100, 49);
            this.BTN_MITerug.TabIndex = 19;
            this.BTN_MITerug.Text = "Terug";
            this.BTN_MITerug.UseVisualStyleBackColor = true;
            this.BTN_MITerug.Click += new System.EventHandler(this.BTN_MITerug_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 713);
            this.Controls.Add(this.BTN_MITerug);
            this.Controls.Add(this.MenuTypesGrid);
            this.Controls.Add(this.BTN_MIDelete);
            this.Controls.Add(this.BTN_MIMenuUpdate);
            this.Controls.Add(this.BTN_MIMenuAdd);
            this.Controls.Add(this.TXTB_MIPrice);
            this.Controls.Add(this.TXTB_MIMenuID);
            this.Controls.Add(this.TXTB_MIMenuName);
            this.Controls.Add(this.TXTB_MIMenuItemID);
            this.Controls.Add(this.AdminMenuGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.AdminMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTypesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminMenuGrid;
        private System.Windows.Forms.TextBox TXTB_MIMenuItemID;
        private System.Windows.Forms.TextBox TXTB_MIMenuName;
        private System.Windows.Forms.TextBox TXTB_MIMenuID;
        private System.Windows.Forms.TextBox TXTB_MIPrice;
        private System.Windows.Forms.Button BTN_MIMenuAdd;
        private System.Windows.Forms.Button BTN_MIMenuUpdate;
        private System.Windows.Forms.Button BTN_MIDelete;
        private System.Windows.Forms.DataGridView MenuTypesGrid;
        private System.Windows.Forms.Button BTN_MITerug;
    }
}