
using System.Drawing;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminMenuGrid = new System.Windows.Forms.DataGridView();
            this.TXTB_MIMenuName = new System.Windows.Forms.TextBox();
            this.TXTB_MIPrice = new System.Windows.Forms.TextBox();
            this.BTN_MIMenuAdd = new System.Windows.Forms.Button();
            this.BTN_MIMenuUpdate = new System.Windows.Forms.Button();
            this.BTN_MIDelete = new System.Windows.Forms.Button();
            this.MenuTypesGrid = new System.Windows.Forms.DataGridView();
            this.BTN_MITerug = new System.Windows.Forms.Button();
            this.TXTB_Menutype = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTypesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminMenuGrid
            // 
            this.AdminMenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminMenuGrid.Location = new System.Drawing.Point(116, 11);
            this.AdminMenuGrid.Name = "AdminMenuGrid";
            this.AdminMenuGrid.RowHeadersWidth = 51;
            this.AdminMenuGrid.RowTemplate.Height = 25;
            this.AdminMenuGrid.Size = new System.Drawing.Size(514, 262);
            this.AdminMenuGrid.TabIndex = 0;
            this.AdminMenuGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminMenuGrid_CellContentClick);
            // 
            // TXTB_MIMenuName
            // 
            this.TXTB_MIMenuName.Location = new System.Drawing.Point(116, 288);
            this.TXTB_MIMenuName.Name = "TXTB_MIMenuName";
            this.TXTB_MIMenuName.PlaceholderText = "Menu Name";
            this.TXTB_MIMenuName.Size = new System.Drawing.Size(100, 23);
            this.TXTB_MIMenuName.TabIndex = 4;
            // 
            // TXTB_MIPrice
            // 
            this.TXTB_MIPrice.Location = new System.Drawing.Point(222, 288);
            this.TXTB_MIPrice.Name = "TXTB_MIPrice";
            this.TXTB_MIPrice.PlaceholderText = "Price";
            this.TXTB_MIPrice.Size = new System.Drawing.Size(100, 23);
            this.TXTB_MIPrice.TabIndex = 8;
            // 
            // BTN_MIMenuAdd
            // 
            this.BTN_MIMenuAdd.Location = new System.Drawing.Point(116, 317);
            this.BTN_MIMenuAdd.Name = "BTN_MIMenuAdd";
            this.BTN_MIMenuAdd.Size = new System.Drawing.Size(91, 41);
            this.BTN_MIMenuAdd.TabIndex = 9;
            this.BTN_MIMenuAdd.Text = "Add";
            this.BTN_MIMenuAdd.UseVisualStyleBackColor = true;
            this.BTN_MIMenuAdd.Click += new System.EventHandler(this.BTN_MIMenuAdd_Click);
            // 
            // BTN_MIMenuUpdate
            // 
            this.BTN_MIMenuUpdate.Location = new System.Drawing.Point(213, 316);
            this.BTN_MIMenuUpdate.Name = "BTN_MIMenuUpdate";
            this.BTN_MIMenuUpdate.Size = new System.Drawing.Size(91, 42);
            this.BTN_MIMenuUpdate.TabIndex = 10;
            this.BTN_MIMenuUpdate.Text = "Update";
            this.BTN_MIMenuUpdate.UseVisualStyleBackColor = true;
            this.BTN_MIMenuUpdate.Click += new System.EventHandler(this.BTN_MIMenuUpdate_Click);
            // 
            // BTN_MIDelete
            // 
            this.BTN_MIDelete.Location = new System.Drawing.Point(310, 317);
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
            this.MenuTypesGrid.Location = new System.Drawing.Point(635, 11);
            this.MenuTypesGrid.Name = "MenuTypesGrid";
            this.MenuTypesGrid.RowHeadersWidth = 51;
            this.MenuTypesGrid.RowTemplate.Height = 25;
            this.MenuTypesGrid.Size = new System.Drawing.Size(354, 262);
            this.MenuTypesGrid.TabIndex = 12;
            this.MenuTypesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuTypesGrid_CellContentClick);
            // 
            // BTN_MITerug
            // 
            this.BTN_MITerug.Location = new System.Drawing.Point(10, 11);
            this.BTN_MITerug.Name = "BTN_MITerug";
            this.BTN_MITerug.Size = new System.Drawing.Size(88, 37);
            this.BTN_MITerug.TabIndex = 19;
            this.BTN_MITerug.Text = "Terug";
            this.BTN_MITerug.UseVisualStyleBackColor = true;
            this.BTN_MITerug.Click += new System.EventHandler(this.BTN_MITerug_Click);
            // 
            // TXTB_Menutype
            // 
            this.TXTB_Menutype.Location = new System.Drawing.Point(328, 288);
            this.TXTB_Menutype.Name = "TXTB_Menutype";
            this.TXTB_Menutype.PlaceholderText = "MenuType";
            this.TXTB_Menutype.Size = new System.Drawing.Size(100, 23);
            this.TXTB_Menutype.TabIndex = 20;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 535);
            this.Controls.Add(this.TXTB_Menutype);
            this.Controls.Add(this.BTN_MITerug);
            this.Controls.Add(this.MenuTypesGrid);
            this.Controls.Add(this.BTN_MIDelete);
            this.Controls.Add(this.BTN_MIMenuUpdate);
            this.Controls.Add(this.BTN_MIMenuAdd);
            this.Controls.Add(this.TXTB_MIPrice);
            this.Controls.Add(this.TXTB_MIMenuName);
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
        private System.Windows.Forms.TextBox TXTB_MIMenuName;
        private System.Windows.Forms.TextBox TXTB_MIPrice;
        private System.Windows.Forms.Button BTN_MIMenuAdd;
        private System.Windows.Forms.Button BTN_MIMenuUpdate;
        private System.Windows.Forms.Button BTN_MIDelete;
        private System.Windows.Forms.DataGridView MenuTypesGrid;
        private System.Windows.Forms.Button BTN_MITerug;
        private System.Windows.Forms.TextBox TXTB_Menutype;
    }
}