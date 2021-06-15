
namespace ChapooDatabaseUI
{
    partial class AdminEmployee
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
            this.AdminEmployGrid = new System.Windows.Forms.DataGridView();
            this.TXTB_ADEmployeeID = new System.Windows.Forms.TextBox();
            this.TXTB_ADLastname = new System.Windows.Forms.TextBox();
            this.TXTB_ADGebruikersnaam = new System.Windows.Forms.TextBox();
            this.TXTB_ADFirstname = new System.Windows.Forms.TextBox();
            this.TXTB_ADPassword = new System.Windows.Forms.TextBox();
            this.TXTB_ADPosition = new System.Windows.Forms.TextBox();
            this.BTN_ADToevoegen = new System.Windows.Forms.Button();
            this.BTN_ADUpdate = new System.Windows.Forms.Button();
            this.BTN_ADDelete = new System.Windows.Forms.Button();
            this.TXTB_ADTelephone = new System.Windows.Forms.TextBox();
            this.BTN_ADTerug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminEmployGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminEmployGrid
            // 
            this.AdminEmployGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminEmployGrid.Location = new System.Drawing.Point(101, 16);
            this.AdminEmployGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminEmployGrid.Name = "AdminEmployGrid";
            this.AdminEmployGrid.RowHeadersWidth = 51;
            this.AdminEmployGrid.RowTemplate.Height = 25;
            this.AdminEmployGrid.Size = new System.Drawing.Size(761, 209);
            this.AdminEmployGrid.TabIndex = 0;
            // 
            // TXTB_ADEmployeeID
            // 
            this.TXTB_ADEmployeeID.Location = new System.Drawing.Point(101, 280);
            this.TXTB_ADEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_ADEmployeeID.Name = "TXTB_ADEmployeeID";
            this.TXTB_ADEmployeeID.PlaceholderText = "ID*";
            this.TXTB_ADEmployeeID.Size = new System.Drawing.Size(245, 27);
            this.TXTB_ADEmployeeID.TabIndex = 2;
            // 
            // TXTB_ADLastname
            // 
            this.TXTB_ADLastname.Location = new System.Drawing.Point(232, 326);
            this.TXTB_ADLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_ADLastname.Name = "TXTB_ADLastname";
            this.TXTB_ADLastname.PlaceholderText = "Last Name*";
            this.TXTB_ADLastname.Size = new System.Drawing.Size(114, 27);
            this.TXTB_ADLastname.TabIndex = 4;
            // 
            // TXTB_ADGebruikersnaam
            // 
            this.TXTB_ADGebruikersnaam.Location = new System.Drawing.Point(101, 370);
            this.TXTB_ADGebruikersnaam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_ADGebruikersnaam.Name = "TXTB_ADGebruikersnaam";
            this.TXTB_ADGebruikersnaam.PlaceholderText = "Email Address*";
            this.TXTB_ADGebruikersnaam.Size = new System.Drawing.Size(245, 27);
            this.TXTB_ADGebruikersnaam.TabIndex = 5;
            // 
            // TXTB_ADFirstname
            // 
            this.TXTB_ADFirstname.Location = new System.Drawing.Point(101, 326);
            this.TXTB_ADFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_ADFirstname.Name = "TXTB_ADFirstname";
            this.TXTB_ADFirstname.PlaceholderText = "First Name*";
            this.TXTB_ADFirstname.Size = new System.Drawing.Size(114, 27);
            this.TXTB_ADFirstname.TabIndex = 8;
            // 
            // TXTB_ADPassword
            // 
            this.TXTB_ADPassword.Location = new System.Drawing.Point(101, 464);
            this.TXTB_ADPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_ADPassword.Name = "TXTB_ADPassword";
            this.TXTB_ADPassword.PasswordChar = '*';
            this.TXTB_ADPassword.PlaceholderText = "Password*";
            this.TXTB_ADPassword.Size = new System.Drawing.Size(245, 27);
            this.TXTB_ADPassword.TabIndex = 10;
            // 
            // TXTB_ADPosition
            // 
            this.TXTB_ADPosition.Location = new System.Drawing.Point(101, 513);
            this.TXTB_ADPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_ADPosition.Name = "TXTB_ADPosition";
            this.TXTB_ADPosition.PlaceholderText = "Position*";
            this.TXTB_ADPosition.Size = new System.Drawing.Size(245, 27);
            this.TXTB_ADPosition.TabIndex = 11;
            // 
            // BTN_ADToevoegen
            // 
            this.BTN_ADToevoegen.Location = new System.Drawing.Point(379, 280);
            this.BTN_ADToevoegen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ADToevoegen.Name = "BTN_ADToevoegen";
            this.BTN_ADToevoegen.Size = new System.Drawing.Size(136, 56);
            this.BTN_ADToevoegen.TabIndex = 13;
            this.BTN_ADToevoegen.Text = "Add";
            this.BTN_ADToevoegen.UseVisualStyleBackColor = true;
            this.BTN_ADToevoegen.Click += new System.EventHandler(this.BTN_ADToevoegen_Click);
            // 
            // BTN_ADUpdate
            // 
            this.BTN_ADUpdate.Location = new System.Drawing.Point(379, 386);
            this.BTN_ADUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ADUpdate.Name = "BTN_ADUpdate";
            this.BTN_ADUpdate.Size = new System.Drawing.Size(136, 56);
            this.BTN_ADUpdate.TabIndex = 14;
            this.BTN_ADUpdate.Text = "Update";
            this.BTN_ADUpdate.UseVisualStyleBackColor = true;
            this.BTN_ADUpdate.Click += new System.EventHandler(this.BTN_ADUpdate_Click);
            // 
            // BTN_ADDelete
            // 
            this.BTN_ADDelete.Location = new System.Drawing.Point(379, 484);
            this.BTN_ADDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ADDelete.Name = "BTN_ADDelete";
            this.BTN_ADDelete.Size = new System.Drawing.Size(136, 56);
            this.BTN_ADDelete.TabIndex = 15;
            this.BTN_ADDelete.Text = "Delete";
            this.BTN_ADDelete.UseVisualStyleBackColor = true;
            this.BTN_ADDelete.Click += new System.EventHandler(this.BTN_ADDelete_Click);
            // 
            // TXTB_ADTelephone
            // 
            this.TXTB_ADTelephone.Location = new System.Drawing.Point(101, 415);
            this.TXTB_ADTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTB_ADTelephone.Name = "TXTB_ADTelephone";
            this.TXTB_ADTelephone.PlaceholderText = "Telephone*";
            this.TXTB_ADTelephone.Size = new System.Drawing.Size(245, 27);
            this.TXTB_ADTelephone.TabIndex = 17;
            // 
            // BTN_ADTerug
            // 
            this.BTN_ADTerug.Location = new System.Drawing.Point(2, 17);
            this.BTN_ADTerug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ADTerug.Name = "BTN_ADTerug";
            this.BTN_ADTerug.Size = new System.Drawing.Size(93, 49);
            this.BTN_ADTerug.TabIndex = 18;
            this.BTN_ADTerug.Text = "Terug";
            this.BTN_ADTerug.UseVisualStyleBackColor = true;
            this.BTN_ADTerug.Click += new System.EventHandler(this.BTN_ADTerug_Click);
            // 
            // AdminEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 595);
            this.Controls.Add(this.BTN_ADTerug);
            this.Controls.Add(this.TXTB_ADTelephone);
            this.Controls.Add(this.BTN_ADDelete);
            this.Controls.Add(this.BTN_ADUpdate);
            this.Controls.Add(this.BTN_ADToevoegen);
            this.Controls.Add(this.TXTB_ADPosition);
            this.Controls.Add(this.TXTB_ADPassword);
            this.Controls.Add(this.TXTB_ADFirstname);
            this.Controls.Add(this.TXTB_ADGebruikersnaam);
            this.Controls.Add(this.TXTB_ADLastname);
            this.Controls.Add(this.TXTB_ADEmployeeID);
            this.Controls.Add(this.AdminEmployGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminEmployee";
            this.Text = "AdminEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.AdminEmployGrid)).EndInit();
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

        private System.Windows.Forms.DataGridView AdminEmployGrid;
        private System.Windows.Forms.TextBox TXTB_ADEmployeeID;
        private System.Windows.Forms.TextBox TXTB_ADLastname;
        private System.Windows.Forms.TextBox TXTB_ADGebruikersnaam;
        private System.Windows.Forms.TextBox TXTB_ADFirstname;
        private System.Windows.Forms.TextBox TXTB_ADPassword;
        private System.Windows.Forms.TextBox TXTB_ADPosition;
        private System.Windows.Forms.Button BTN_ADToevoegen;
        private System.Windows.Forms.Button BTN_ADUpdate;
        private System.Windows.Forms.Button BTN_ADDelete;
        private System.Windows.Forms.TextBox TXTB_ADTelephone;
        private System.Windows.Forms.Button BTN_ADTerug;
    }
}