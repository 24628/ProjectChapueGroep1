
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
            this.LBL_ADEmployeeID = new System.Windows.Forms.Label();
            this.TXTB_ADEmployeeID = new System.Windows.Forms.TextBox();
            this.LBL_ADLastname = new System.Windows.Forms.Label();
            this.TXTB_ADLastname = new System.Windows.Forms.TextBox();
            this.TXTB_ADGebruikersnaam = new System.Windows.Forms.TextBox();
            this.LBL_ADGebruikersnaam = new System.Windows.Forms.Label();
            this.LBL_ADFirstname = new System.Windows.Forms.Label();
            this.TXTB_ADFirstname = new System.Windows.Forms.TextBox();
            this.LBL_ADPassword = new System.Windows.Forms.Label();
            this.TXTB_ADPassword = new System.Windows.Forms.TextBox();
            this.TXTB_ADPosition = new System.Windows.Forms.TextBox();
            this.LBL_ADPosition = new System.Windows.Forms.Label();
            this.BTN_ADToevoegen = new System.Windows.Forms.Button();
            this.BTN_ADUpdate = new System.Windows.Forms.Button();
            this.BTN_ADDelete = new System.Windows.Forms.Button();
            this.LBL_ADTelephone = new System.Windows.Forms.Label();
            this.TXTB_ADTelephone = new System.Windows.Forms.TextBox();
            this.BTN_ADTerug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminEmployGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminEmployGrid
            // 
            this.AdminEmployGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminEmployGrid.Location = new System.Drawing.Point(76, 12);
            this.AdminEmployGrid.Name = "AdminEmployGrid";
            this.AdminEmployGrid.RowTemplate.Height = 25;
            this.AdminEmployGrid.Size = new System.Drawing.Size(555, 157);
            this.AdminEmployGrid.TabIndex = 0;
            // 
            // LBL_ADEmployeeID
            // 
            this.LBL_ADEmployeeID.AutoSize = true;
            this.LBL_ADEmployeeID.Location = new System.Drawing.Point(112, 263);
            this.LBL_ADEmployeeID.Name = "LBL_ADEmployeeID";
            this.LBL_ADEmployeeID.Size = new System.Drawing.Size(76, 15);
            this.LBL_ADEmployeeID.TabIndex = 1;
            this.LBL_ADEmployeeID.Text = "Employee ID:";
            // 
            // TXTB_ADEmployeeID
            // 
            this.TXTB_ADEmployeeID.Location = new System.Drawing.Point(112, 281);
            this.TXTB_ADEmployeeID.Name = "TXTB_ADEmployeeID";
            this.TXTB_ADEmployeeID.Size = new System.Drawing.Size(100, 23);
            this.TXTB_ADEmployeeID.TabIndex = 2;
            // 
            // LBL_ADLastname
            // 
            this.LBL_ADLastname.AutoSize = true;
            this.LBL_ADLastname.Location = new System.Drawing.Point(270, 263);
            this.LBL_ADLastname.Name = "LBL_ADLastname";
            this.LBL_ADLastname.Size = new System.Drawing.Size(75, 15);
            this.LBL_ADLastname.TabIndex = 3;
            this.LBL_ADLastname.Text = "Achternaam:";
            // 
            // TXTB_ADLastname
            // 
            this.TXTB_ADLastname.Location = new System.Drawing.Point(270, 281);
            this.TXTB_ADLastname.Name = "TXTB_ADLastname";
            this.TXTB_ADLastname.Size = new System.Drawing.Size(100, 23);
            this.TXTB_ADLastname.TabIndex = 4;
            // 
            // TXTB_ADGebruikersnaam
            // 
            this.TXTB_ADGebruikersnaam.Location = new System.Drawing.Point(112, 325);
            this.TXTB_ADGebruikersnaam.Name = "TXTB_ADGebruikersnaam";
            this.TXTB_ADGebruikersnaam.Size = new System.Drawing.Size(100, 23);
            this.TXTB_ADGebruikersnaam.TabIndex = 5;
            // 
            // LBL_ADGebruikersnaam
            // 
            this.LBL_ADGebruikersnaam.AutoSize = true;
            this.LBL_ADGebruikersnaam.Location = new System.Drawing.Point(112, 307);
            this.LBL_ADGebruikersnaam.Name = "LBL_ADGebruikersnaam";
            this.LBL_ADGebruikersnaam.Size = new System.Drawing.Size(99, 15);
            this.LBL_ADGebruikersnaam.TabIndex = 6;
            this.LBL_ADGebruikersnaam.Text = "Gebruikersnaam: ";
            // 
            // LBL_ADFirstname
            // 
            this.LBL_ADFirstname.AutoSize = true;
            this.LBL_ADFirstname.Location = new System.Drawing.Point(270, 307);
            this.LBL_ADFirstname.Name = "LBL_ADFirstname";
            this.LBL_ADFirstname.Size = new System.Drawing.Size(64, 15);
            this.LBL_ADFirstname.TabIndex = 7;
            this.LBL_ADFirstname.Text = "Voornaam:";
            // 
            // TXTB_ADFirstname
            // 
            this.TXTB_ADFirstname.Location = new System.Drawing.Point(270, 325);
            this.TXTB_ADFirstname.Name = "TXTB_ADFirstname";
            this.TXTB_ADFirstname.Size = new System.Drawing.Size(100, 23);
            this.TXTB_ADFirstname.TabIndex = 8;
            // 
            // LBL_ADPassword
            // 
            this.LBL_ADPassword.AutoSize = true;
            this.LBL_ADPassword.Location = new System.Drawing.Point(113, 351);
            this.LBL_ADPassword.Name = "LBL_ADPassword";
            this.LBL_ADPassword.Size = new System.Drawing.Size(60, 15);
            this.LBL_ADPassword.TabIndex = 9;
            this.LBL_ADPassword.Text = "Password:";
            // 
            // TXTB_ADPassword
            // 
            this.TXTB_ADPassword.Location = new System.Drawing.Point(112, 369);
            this.TXTB_ADPassword.Name = "TXTB_ADPassword";
            this.TXTB_ADPassword.Size = new System.Drawing.Size(100, 23);
            this.TXTB_ADPassword.TabIndex = 10;
            // 
            // TXTB_ADPosition
            // 
            this.TXTB_ADPosition.Location = new System.Drawing.Point(270, 369);
            this.TXTB_ADPosition.Name = "TXTB_ADPosition";
            this.TXTB_ADPosition.Size = new System.Drawing.Size(100, 23);
            this.TXTB_ADPosition.TabIndex = 11;
            // 
            // LBL_ADPosition
            // 
            this.LBL_ADPosition.AutoSize = true;
            this.LBL_ADPosition.Location = new System.Drawing.Point(270, 351);
            this.LBL_ADPosition.Name = "LBL_ADPosition";
            this.LBL_ADPosition.Size = new System.Drawing.Size(53, 15);
            this.LBL_ADPosition.TabIndex = 12;
            this.LBL_ADPosition.Text = "Position:";
            // 
            // BTN_ADToevoegen
            // 
            this.BTN_ADToevoegen.Location = new System.Drawing.Point(423, 325);
            this.BTN_ADToevoegen.Name = "BTN_ADToevoegen";
            this.BTN_ADToevoegen.Size = new System.Drawing.Size(86, 42);
            this.BTN_ADToevoegen.TabIndex = 13;
            this.BTN_ADToevoegen.Text = "Add";
            this.BTN_ADToevoegen.UseVisualStyleBackColor = true;
            this.BTN_ADToevoegen.Click += new System.EventHandler(this.BTN_ADToevoegen_Click);
            // 
            // BTN_ADUpdate
            // 
            this.BTN_ADUpdate.Location = new System.Drawing.Point(423, 263);
            this.BTN_ADUpdate.Name = "BTN_ADUpdate";
            this.BTN_ADUpdate.Size = new System.Drawing.Size(86, 42);
            this.BTN_ADUpdate.TabIndex = 14;
            this.BTN_ADUpdate.Text = "Update";
            this.BTN_ADUpdate.UseVisualStyleBackColor = true;
            this.BTN_ADUpdate.Click += new System.EventHandler(this.BTN_ADUpdate_Click);
            // 
            // BTN_ADDelete
            // 
            this.BTN_ADDelete.Location = new System.Drawing.Point(423, 390);
            this.BTN_ADDelete.Name = "BTN_ADDelete";
            this.BTN_ADDelete.Size = new System.Drawing.Size(86, 42);
            this.BTN_ADDelete.TabIndex = 15;
            this.BTN_ADDelete.Text = "Delete";
            this.BTN_ADDelete.UseVisualStyleBackColor = true;
            this.BTN_ADDelete.Click += new System.EventHandler(this.BTN_ADDelete_Click);
            // 
            // LBL_ADTelephone
            // 
            this.LBL_ADTelephone.AutoSize = true;
            this.LBL_ADTelephone.Location = new System.Drawing.Point(113, 399);
            this.LBL_ADTelephone.Name = "LBL_ADTelephone";
            this.LBL_ADTelephone.Size = new System.Drawing.Size(64, 15);
            this.LBL_ADTelephone.TabIndex = 16;
            this.LBL_ADTelephone.Text = "Telephone:";
            // 
            // TXTB_ADTelephone
            // 
            this.TXTB_ADTelephone.Location = new System.Drawing.Point(112, 415);
            this.TXTB_ADTelephone.Name = "TXTB_ADTelephone";
            this.TXTB_ADTelephone.Size = new System.Drawing.Size(100, 23);
            this.TXTB_ADTelephone.TabIndex = 17;
            // 
            // BTN_ADTerug
            // 
            this.BTN_ADTerug.Location = new System.Drawing.Point(13, 13);
            this.BTN_ADTerug.Name = "BTN_ADTerug";
            this.BTN_ADTerug.Size = new System.Drawing.Size(57, 37);
            this.BTN_ADTerug.TabIndex = 18;
            this.BTN_ADTerug.Text = "Terug";
            this.BTN_ADTerug.UseVisualStyleBackColor = true;
            this.BTN_ADTerug.Click += new System.EventHandler(this.BTN_ADTerug_Click);
            // 
            // AdminEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.BTN_ADTerug);
            this.Controls.Add(this.TXTB_ADTelephone);
            this.Controls.Add(this.LBL_ADTelephone);
            this.Controls.Add(this.BTN_ADDelete);
            this.Controls.Add(this.BTN_ADUpdate);
            this.Controls.Add(this.BTN_ADToevoegen);
            this.Controls.Add(this.LBL_ADPosition);
            this.Controls.Add(this.TXTB_ADPosition);
            this.Controls.Add(this.TXTB_ADPassword);
            this.Controls.Add(this.LBL_ADPassword);
            this.Controls.Add(this.TXTB_ADFirstname);
            this.Controls.Add(this.LBL_ADFirstname);
            this.Controls.Add(this.LBL_ADGebruikersnaam);
            this.Controls.Add(this.TXTB_ADGebruikersnaam);
            this.Controls.Add(this.TXTB_ADLastname);
            this.Controls.Add(this.LBL_ADLastname);
            this.Controls.Add(this.TXTB_ADEmployeeID);
            this.Controls.Add(this.LBL_ADEmployeeID);
            this.Controls.Add(this.AdminEmployGrid);
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
        private System.Windows.Forms.Label LBL_ADEmployeeID;
        private System.Windows.Forms.TextBox TXTB_ADEmployeeID;
        private System.Windows.Forms.Label LBL_ADLastname;
        private System.Windows.Forms.TextBox TXTB_ADLastname;
        private System.Windows.Forms.TextBox TXTB_ADGebruikersnaam;
        private System.Windows.Forms.Label LBL_ADGebruikersnaam;
        private System.Windows.Forms.Label LBL_ADFirstname;
        private System.Windows.Forms.TextBox TXTB_ADFirstname;
        private System.Windows.Forms.Label LBL_ADPassword;
        private System.Windows.Forms.TextBox TXTB_ADPassword;
        private System.Windows.Forms.TextBox TXTB_ADPosition;
        private System.Windows.Forms.Label LBL_ADPosition;
        private System.Windows.Forms.Button BTN_ADToevoegen;
        private System.Windows.Forms.Button BTN_ADUpdate;
        private System.Windows.Forms.Button BTN_ADDelete;
        private System.Windows.Forms.Label LBL_ADTelephone;
        private System.Windows.Forms.TextBox TXTB_ADTelephone;
        private System.Windows.Forms.Button BTN_ADTerug;
    }
}