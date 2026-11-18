namespace WinFormsApp1.Forms
{
    partial class RentalManagementForm
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
            lblCustomer = new Label();
            cmbCustomers = new ComboBox();
            lblVehicle = new Label();
            cmbVehicles = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblTotalPriceTitle = new Label();
            lblTotalPrice = new Label();
            btnCreateRental = new Button();
            dgvRentals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRentals).BeginInit();
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
            lblFormTitle.Text = "ARAÇ KİRALAMA";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(30, 100);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(71, 15);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Müşteri Seç:";
            // 
            // cmbCustomers
            // 
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(150, 95);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(250, 23);
            cmbCustomers.TabIndex = 2;
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(30, 160);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(55, 15);
            lblVehicle.TabIndex = 3;
            lblVehicle.Text = "Araç Seç:";
            // 
            // cmbVehicles
            // 
            cmbVehicles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicles.FormattingEnabled = true;
            cmbVehicles.Location = new Point(150, 155);
            cmbVehicles.Name = "cmbVehicles";
            cmbVehicles.Size = new Size(250, 23);
            cmbVehicles.TabIndex = 4;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(30, 220);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(92, 15);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Başlangıç Tarihi:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(150, 215);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 23);
            dtpStartDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(30, 280);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(64, 15);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "Bitiş Tarihi:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(150, 275);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 23);
            dtpEndDate.TabIndex = 8;
            // 
            // lblTotalPriceTitle
            // 
            lblTotalPriceTitle.AutoSize = true;
            lblTotalPriceTitle.Location = new Point(30, 340);
            lblTotalPriceTitle.Name = "lblTotalPriceTitle";
            lblTotalPriceTitle.Size = new Size(81, 15);
            lblTotalPriceTitle.TabIndex = 9;
            lblTotalPriceTitle.Text = "Toplam Ücret:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Microsoft Sans Serif", 18F);
            lblTotalPrice.ForeColor = Color.DarkGreen;
            lblTotalPrice.Location = new Point(150, 335);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(250, 35);
            lblTotalPrice.TabIndex = 10;
            lblTotalPrice.Text = "0,00 TL";
            // 
            // btnCreateRental
            // 
            btnCreateRental.BackColor = Color.SeaGreen;
            btnCreateRental.FlatStyle = FlatStyle.Flat;
            btnCreateRental.Font = new Font("Microsoft Sans Serif", 18F);
            btnCreateRental.ForeColor = Color.White;
            btnCreateRental.Location = new Point(150, 410);
            btnCreateRental.Name = "btnCreateRental";
            btnCreateRental.Size = new Size(250, 41);
            btnCreateRental.TabIndex = 11;
            btnCreateRental.Text = "KİRALA";
            btnCreateRental.UseVisualStyleBackColor = false;
            // 
            // dgvRentals
            // 
            dgvRentals.AllowUserToAddRows = false;
            dgvRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentals.Location = new Point(30, 490);
            dgvRentals.MultiSelect = false;
            dgvRentals.Name = "dgvRentals";
            dgvRentals.ReadOnly = true;
            dgvRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentals.Size = new Size(920, 150);
            dgvRentals.TabIndex = 12;
            // 
            // RentalManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(dgvRentals);
            Controls.Add(btnCreateRental);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotalPriceTitle);
            Controls.Add(dtpEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(cmbVehicles);
            Controls.Add(lblVehicle);
            Controls.Add(cmbCustomers);
            Controls.Add(lblCustomer);
            Controls.Add(lblFormTitle);
            MinimumSize = new Size(900, 650);
            Name = "RentalManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARAÇ KİRALAMA";
            ((System.ComponentModel.ISupportInitialize)dgvRentals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblCustomer;
        private ComboBox cmbCustomers;
        private Label lblVehicle;
        private ComboBox cmbVehicles;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblTotalPriceTitle;
        private Label lblTotalPrice;
        private Button btnCreateRental;
        private DataGridView dgvRentals;
    }
}