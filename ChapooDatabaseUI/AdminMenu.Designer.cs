
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
            this.LBL_MIMenuItem = new System.Windows.Forms.Label();
            this.TXTB_MIMenuItemID = new System.Windows.Forms.TextBox();
            this.LBL_MIMenuName = new System.Windows.Forms.Label();
            this.TXTB_MIMenuName = new System.Windows.Forms.TextBox();
            this.LBL_MIMenuID = new System.Windows.Forms.Label();
            this.LBL_MIPrice = new System.Windows.Forms.Label();
            this.TXTB_MIMenuID = new System.Windows.Forms.TextBox();
            this.TXTB_MIPrice = new System.Windows.Forms.TextBox();
            this.BTN_MIMenuAdd = new System.Windows.Forms.Button();
            this.BTN_MIMenuUpdate = new System.Windows.Forms.Button();
            this.BTN_MIDelete = new System.Windows.Forms.Button();
            this.MenuTypesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTypesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminMenuGrid
            // 
            this.AdminMenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminMenuGrid.Location = new System.Drawing.Point(12, 12);
            this.AdminMenuGrid.Name = "AdminMenuGrid";
            this.AdminMenuGrid.RowTemplate.Height = 25;
            this.AdminMenuGrid.Size = new System.Drawing.Size(514, 262);
            this.AdminMenuGrid.TabIndex = 0;
            // 
            // LBL_MIMenuItem
            // 
            this.LBL_MIMenuItem.AutoSize = true;
            this.LBL_MIMenuItem.Location = new System.Drawing.Point(434, 294);
            this.LBL_MIMenuItem.Name = "LBL_MIMenuItem";
            this.LBL_MIMenuItem.Size = new System.Drawing.Size(48, 15);
            this.LBL_MIMenuItem.TabIndex = 1;
            this.LBL_MIMenuItem.Text = "Item ID:";
            // 
            // TXTB_MIMenuItemID
            // 
            this.TXTB_MIMenuItemID.Location = new System.Drawing.Point(434, 313);
            this.TXTB_MIMenuItemID.Name = "TXTB_MIMenuItemID";
            this.TXTB_MIMenuItemID.Size = new System.Drawing.Size(100, 23);
            this.TXTB_MIMenuItemID.TabIndex = 2;
            // 
            // LBL_MIMenuName
            // 
            this.LBL_MIMenuName.AutoSize = true;
            this.LBL_MIMenuName.Location = new System.Drawing.Point(652, 294);
            this.LBL_MIMenuName.Name = "LBL_MIMenuName";
            this.LBL_MIMenuName.Size = new System.Drawing.Size(76, 15);
            this.LBL_MIMenuName.TabIndex = 3;
            this.LBL_MIMenuName.Text = "Menu Name:";
            // 
            // TXTB_MIMenuName
            // 
            this.TXTB_MIMenuName.Location = new System.Drawing.Point(652, 312);
            this.TXTB_MIMenuName.Name = "TXTB_MIMenuName";
            this.TXTB_MIMenuName.Size = new System.Drawing.Size(100, 23);
            this.TXTB_MIMenuName.TabIndex = 4;
            // 
            // LBL_MIMenuID
            // 
            this.LBL_MIMenuID.AutoSize = true;
            this.LBL_MIMenuID.Location = new System.Drawing.Point(434, 343);
            this.LBL_MIMenuID.Name = "LBL_MIMenuID";
            this.LBL_MIMenuID.Size = new System.Drawing.Size(55, 15);
            this.LBL_MIMenuID.TabIndex = 5;
            this.LBL_MIMenuID.Text = "Menu ID:";
            // 
            // LBL_MIPrice
            // 
            this.LBL_MIPrice.AutoSize = true;
            this.LBL_MIPrice.Location = new System.Drawing.Point(652, 343);
            this.LBL_MIPrice.Name = "LBL_MIPrice";
            this.LBL_MIPrice.Size = new System.Drawing.Size(36, 15);
            this.LBL_MIPrice.TabIndex = 6;
            this.LBL_MIPrice.Text = "Price:";
            // 
            // TXTB_MIMenuID
            // 
            this.TXTB_MIMenuID.Location = new System.Drawing.Point(434, 362);
            this.TXTB_MIMenuID.Name = "TXTB_MIMenuID";
            this.TXTB_MIMenuID.Size = new System.Drawing.Size(100, 23);
            this.TXTB_MIMenuID.TabIndex = 7;
            // 
            // TXTB_MIPrice
            // 
            this.TXTB_MIPrice.Location = new System.Drawing.Point(652, 362);
            this.TXTB_MIPrice.Name = "TXTB_MIPrice";
            this.TXTB_MIPrice.Size = new System.Drawing.Size(100, 23);
            this.TXTB_MIPrice.TabIndex = 8;
            // 
            // BTN_MIMenuAdd
            // 
            this.BTN_MIMenuAdd.Location = new System.Drawing.Point(799, 352);
            this.BTN_MIMenuAdd.Name = "BTN_MIMenuAdd";
            this.BTN_MIMenuAdd.Size = new System.Drawing.Size(91, 41);
            this.BTN_MIMenuAdd.TabIndex = 9;
            this.BTN_MIMenuAdd.Text = "Add";
            this.BTN_MIMenuAdd.UseVisualStyleBackColor = true;
            this.BTN_MIMenuAdd.Click += new System.EventHandler(this.BTN_MIMenuAdd_Click);
            // 
            // BTN_MIMenuUpdate
            // 
            this.BTN_MIMenuUpdate.Location = new System.Drawing.Point(799, 294);
            this.BTN_MIMenuUpdate.Name = "BTN_MIMenuUpdate";
            this.BTN_MIMenuUpdate.Size = new System.Drawing.Size(91, 42);
            this.BTN_MIMenuUpdate.TabIndex = 10;
            this.BTN_MIMenuUpdate.Text = "Update";
            this.BTN_MIMenuUpdate.UseVisualStyleBackColor = true;
            this.BTN_MIMenuUpdate.Click += new System.EventHandler(this.BTN_MIMenuUpdate_Click);
            // 
            // BTN_MIDelete
            // 
            this.BTN_MIDelete.Location = new System.Drawing.Point(799, 410);
            this.BTN_MIDelete.Name = "BTN_MIDelete";
            this.BTN_MIDelete.Size = new System.Drawing.Size(91, 41);
            this.BTN_MIDelete.TabIndex = 11;
            this.BTN_MIDelete.Text = "Delete";
            this.BTN_MIDelete.UseVisualStyleBackColor = true;
            this.BTN_MIDelete.Click += new System.EventHandler(this.BTN_MIDelete_Click);
            // 
            // MenuTypesGrid
            // 
            this.MenuTypesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuTypesGrid.Location = new System.Drawing.Point(536, 12);
            this.MenuTypesGrid.Name = "MenuTypesGrid";
            this.MenuTypesGrid.RowTemplate.Height = 25;
            this.MenuTypesGrid.Size = new System.Drawing.Size(354, 262);
            this.MenuTypesGrid.TabIndex = 12;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 535);
            this.Controls.Add(this.MenuTypesGrid);
            this.Controls.Add(this.BTN_MIDelete);
            this.Controls.Add(this.BTN_MIMenuUpdate);
            this.Controls.Add(this.BTN_MIMenuAdd);
            this.Controls.Add(this.TXTB_MIPrice);
            this.Controls.Add(this.TXTB_MIMenuID);
            this.Controls.Add(this.LBL_MIPrice);
            this.Controls.Add(this.LBL_MIMenuID);
            this.Controls.Add(this.TXTB_MIMenuName);
            this.Controls.Add(this.LBL_MIMenuName);
            this.Controls.Add(this.TXTB_MIMenuItemID);
            this.Controls.Add(this.LBL_MIMenuItem);
            this.Controls.Add(this.AdminMenuGrid);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.AdminMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTypesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminMenuGrid;
        private System.Windows.Forms.Label LBL_MIMenuItem;
        private System.Windows.Forms.TextBox TXTB_MIMenuItemID;
        private System.Windows.Forms.Label LBL_MIMenuName;
        private System.Windows.Forms.TextBox TXTB_MIMenuName;
        private System.Windows.Forms.Label LBL_MIMenuID;
        private System.Windows.Forms.Label LBL_MIPrice;
        private System.Windows.Forms.TextBox TXTB_MIMenuID;
        private System.Windows.Forms.TextBox TXTB_MIPrice;
        private System.Windows.Forms.Button BTN_MIMenuAdd;
        private System.Windows.Forms.Button BTN_MIMenuUpdate;
        private System.Windows.Forms.Button BTN_MIDelete;
        private System.Windows.Forms.DataGridView MenuTypesGrid;
    }
}