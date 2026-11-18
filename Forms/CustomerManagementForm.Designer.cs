namespace WinFormsApp1.Forms
{
    partial class CustomerManagementForm
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
            lblFormTitle = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblLicenseNumber = new Label();
            txtLicenseNumber = new TextBox();
            btnAddCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnClearCustomer = new Button();
            dgvCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 18F);
            lblFormTitle.ForeColor = Color.SteelBlue;
            lblFormTitle.Location = new Point(30, 20);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(400, 45);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "MÜŞTERİ YÖNETİMİ";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 90);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(25, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Ad:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(110, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(180, 23);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(320, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(42, 15);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Soyad:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(400, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(180, 23);
            txtLastName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(30, 140);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(49, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Telefon:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(110, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 23);
            txtPhone.TabIndex = 6;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(320, 140);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(64, 15);
            lblLicenseNumber.TabIndex = 7;
            lblLicenseNumber.Text = "Ehliyet No:";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(420, 135);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(180, 23);
            txtLicenseNumber.TabIndex = 8;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.SeaGreen;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(650, 90);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(130, 40);
            btnAddCustomer.TabIndex = 9;
            btnAddCustomer.Text = "MÜŞTERİ EKLE";
            btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.DarkOrange;
            btnUpdateCustomer.FlatStyle = FlatStyle.Flat;
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(650, 140);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(130, 40);
            btnUpdateCustomer.TabIndex = 10;
            btnUpdateCustomer.Text = "GÜNCELLE";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.IndianRed;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(800, 90);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(130, 40);
            btnDeleteCustomer.TabIndex = 11;
            btnDeleteCustomer.Text = "SİL";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnClearCustomer
            // 
            btnClearCustomer.BackColor = Color.DimGray;
            btnClearCustomer.FlatStyle = FlatStyle.Flat;
            btnClearCustomer.ForeColor = Color.White;
            btnClearCustomer.Location = new Point(800, 140);
            btnClearCustomer.Name = "btnClearCustomer";
            btnClearCustomer.Size = new Size(130, 40);
            btnClearCustomer.TabIndex = 12;
            btnClearCustomer.Text = "TEMİZLE";
            btnClearCustomer.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(30, 250);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(918, 350);
            dgvCustomers.TabIndex = 13;
            // 
            // CustomerManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(dgvCustomers);
            Controls.Add(btnClearCustomer);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtLicenseNumber);
            Controls.Add(lblLicenseNumber);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(lblFormTitle);
            MaximumSize = new Size(1000, 650);
            Name = "CustomerManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MÜŞTERİ YÖNETİMİ";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblLicenseNumber;
        private TextBox txtLicenseNumber;
        private Button btnAddCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private Button btnClearCustomer;
        private DataGridView dgvCustomers;
    }
}