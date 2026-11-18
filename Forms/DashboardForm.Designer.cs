namespace WinFormsApp1.Forms
{
    partial class DashboardForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlStatistics = new Panel();
            pnlTotalVehicles = new Panel();
            pnlAvailableVehicles = new Panel();
            pnlRentedVehicles = new Panel();
            pnlTotalCustomers = new Panel();
            pnlActiveRentals = new Panel();
            lblTotalVehiclesTitle = new Label();
            lblAvailableVehiclesTitle = new Label();
            lblRentedVehiclesTitle = new Label();
            lblTotalCustomersTitle = new Label();
            lblActiveRentalsTitle = new Label();
            lblTotalVehiclesCount = new Label();
            lblAvailableVehiclesCount = new Label();
            lblRentedVehiclesCount = new Label();
            lblTotalCustomersCount = new Label();
            lblActiveRentalsCount = new Label();
            btnVehicleManagement = new Button();
            btnCustomerManagement = new Button();
            btnRentalManagement = new Button();
            btnVehicleReturn = new Button();
            pnlHeader.SuspendLayout();
            pnlStatistics.SuspendLayout();
            pnlTotalVehicles.SuspendLayout();
            pnlAvailableVehicles.SuspendLayout();
            pnlRentedVehicles.SuspendLayout();
            pnlTotalCustomers.SuspendLayout();
            pnlActiveRentals.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1084, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1084, 90);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ARAÇ KİRALAMA YÖNETİM SİSTEMİ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStatistics
            // 
            pnlStatistics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlStatistics.BackColor = Color.WhiteSmoke;
            pnlStatistics.Controls.Add(pnlActiveRentals);
            pnlStatistics.Controls.Add(pnlTotalCustomers);
            pnlStatistics.Controls.Add(pnlRentedVehicles);
            pnlStatistics.Controls.Add(pnlAvailableVehicles);
            pnlStatistics.Controls.Add(pnlTotalVehicles);
            pnlStatistics.Location = new Point(42, 96);
            pnlStatistics.Name = "pnlStatistics";
            pnlStatistics.Size = new Size(1000, 180);
            pnlStatistics.TabIndex = 1;
            // 
            // pnlTotalVehicles
            // 
            pnlTotalVehicles.BackColor = Color.LightSteelBlue;
            pnlTotalVehicles.Controls.Add(lblTotalVehiclesCount);
            pnlTotalVehicles.Controls.Add(lblTotalVehiclesTitle);
            pnlTotalVehicles.Location = new Point(15, 20);
            pnlTotalVehicles.Name = "pnlTotalVehicles";
            pnlTotalVehicles.Size = new Size(180, 130);
            pnlTotalVehicles.TabIndex = 0;
            // 
            // pnlAvailableVehicles
            // 
            pnlAvailableVehicles.BackColor = Color.LightGreen;
            pnlAvailableVehicles.Controls.Add(lblAvailableVehiclesCount);
            pnlAvailableVehicles.Controls.Add(lblAvailableVehiclesTitle);
            pnlAvailableVehicles.Location = new Point(210, 20);
            pnlAvailableVehicles.Name = "pnlAvailableVehicles";
            pnlAvailableVehicles.Size = new Size(180, 130);
            pnlAvailableVehicles.TabIndex = 1;
            // 
            // pnlRentedVehicles
            // 
            pnlRentedVehicles.BackColor = Color.LightSalmon;
            pnlRentedVehicles.Controls.Add(lblRentedVehiclesCount);
            pnlRentedVehicles.Controls.Add(lblRentedVehiclesTitle);
            pnlRentedVehicles.Location = new Point(405, 20);
            pnlRentedVehicles.Name = "pnlRentedVehicles";
            pnlRentedVehicles.Size = new Size(180, 130);
            pnlRentedVehicles.TabIndex = 1;
            // 
            // pnlTotalCustomers
            // 
            pnlTotalCustomers.BackColor = Color.LightSteelBlue;
            pnlTotalCustomers.Controls.Add(lblTotalCustomersCount);
            pnlTotalCustomers.Controls.Add(lblTotalCustomersTitle);
            pnlTotalCustomers.Location = new Point(600, 20);
            pnlTotalCustomers.Name = "pnlTotalCustomers";
            pnlTotalCustomers.Size = new Size(180, 130);
            pnlTotalCustomers.TabIndex = 1;
            // 
            // pnlActiveRentals
            // 
            pnlActiveRentals.BackColor = Color.LightSkyBlue;
            pnlActiveRentals.Controls.Add(lblActiveRentalsCount);
            pnlActiveRentals.Controls.Add(lblActiveRentalsTitle);
            pnlActiveRentals.Location = new Point(795, 20);
            pnlActiveRentals.Name = "pnlActiveRentals";
            pnlActiveRentals.Size = new Size(180, 130);
            pnlActiveRentals.TabIndex = 1;
            // 
            // lblTotalVehiclesTitle
            // 
            lblTotalVehiclesTitle.BackColor = Color.Transparent;
            lblTotalVehiclesTitle.Dock = DockStyle.Top;
            lblTotalVehiclesTitle.Font = new Font("Microsoft Sans Serif", 11F);
            lblTotalVehiclesTitle.Location = new Point(0, 0);
            lblTotalVehiclesTitle.Name = "lblTotalVehiclesTitle";
            lblTotalVehiclesTitle.Size = new Size(180, 40);
            lblTotalVehiclesTitle.TabIndex = 0;
            lblTotalVehiclesTitle.Text = "TOPLAM ARAÇ";
            lblTotalVehiclesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvailableVehiclesTitle
            // 
            lblAvailableVehiclesTitle.BackColor = Color.Transparent;
            lblAvailableVehiclesTitle.Dock = DockStyle.Top;
            lblAvailableVehiclesTitle.Font = new Font("Microsoft Sans Serif", 11F);
            lblAvailableVehiclesTitle.Location = new Point(0, 0);
            lblAvailableVehiclesTitle.Name = "lblAvailableVehiclesTitle";
            lblAvailableVehiclesTitle.Size = new Size(180, 40);
            lblAvailableVehiclesTitle.TabIndex = 0;
            lblAvailableVehiclesTitle.Text = "MÜSAİT ARAÇ";
            lblAvailableVehiclesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRentedVehiclesTitle
            // 
            lblRentedVehiclesTitle.BackColor = Color.Transparent;
            lblRentedVehiclesTitle.Dock = DockStyle.Top;
            lblRentedVehiclesTitle.Font = new Font("Microsoft Sans Serif", 11F);
            lblRentedVehiclesTitle.Location = new Point(0, 0);
            lblRentedVehiclesTitle.Name = "lblRentedVehiclesTitle";
            lblRentedVehiclesTitle.Size = new Size(180, 40);
            lblRentedVehiclesTitle.TabIndex = 1;
            lblRentedVehiclesTitle.Text = "KİRADAKİ ARAÇ";
            lblRentedVehiclesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomersTitle
            // 
            lblTotalCustomersTitle.BackColor = Color.Transparent;
            lblTotalCustomersTitle.Dock = DockStyle.Top;
            lblTotalCustomersTitle.Font = new Font("Microsoft Sans Serif", 11F);
            lblTotalCustomersTitle.Location = new Point(0, 0);
            lblTotalCustomersTitle.Name = "lblTotalCustomersTitle";
            lblTotalCustomersTitle.Size = new Size(180, 40);
            lblTotalCustomersTitle.TabIndex = 1;
            lblTotalCustomersTitle.Text = "TOPLAM MÜŞTERİ";
            lblTotalCustomersTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveRentalsTitle
            // 
            lblActiveRentalsTitle.BackColor = Color.Transparent;
            lblActiveRentalsTitle.Dock = DockStyle.Top;
            lblActiveRentalsTitle.Font = new Font("Microsoft Sans Serif", 11F);
            lblActiveRentalsTitle.Location = new Point(0, 0);
            lblActiveRentalsTitle.Name = "lblActiveRentalsTitle";
            lblActiveRentalsTitle.Size = new Size(180, 40);
            lblActiveRentalsTitle.TabIndex = 1;
            lblActiveRentalsTitle.Text = "AKTİF KİRALAMA";
            lblActiveRentalsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalVehiclesCount
            // 
            lblTotalVehiclesCount.BackColor = Color.Transparent;
            lblTotalVehiclesCount.Dock = DockStyle.Fill;
            lblTotalVehiclesCount.Font = new Font("Microsoft Sans Serif", 26F);
            lblTotalVehiclesCount.ForeColor = Color.Navy;
            lblTotalVehiclesCount.Location = new Point(0, 40);
            lblTotalVehiclesCount.Name = "lblTotalVehiclesCount";
            lblTotalVehiclesCount.Size = new Size(180, 90);
            lblTotalVehiclesCount.TabIndex = 1;
            lblTotalVehiclesCount.Text = "0";
            lblTotalVehiclesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvailableVehiclesCount
            // 
            lblAvailableVehiclesCount.BackColor = Color.Transparent;
            lblAvailableVehiclesCount.Dock = DockStyle.Fill;
            lblAvailableVehiclesCount.Font = new Font("Microsoft Sans Serif", 26F);
            lblAvailableVehiclesCount.ForeColor = Color.Navy;
            lblAvailableVehiclesCount.Location = new Point(0, 40);
            lblAvailableVehiclesCount.Name = "lblAvailableVehiclesCount";
            lblAvailableVehiclesCount.Size = new Size(180, 90);
            lblAvailableVehiclesCount.TabIndex = 2;
            lblAvailableVehiclesCount.Text = "0";
            lblAvailableVehiclesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRentedVehiclesCount
            // 
            lblRentedVehiclesCount.BackColor = Color.Transparent;
            lblRentedVehiclesCount.Dock = DockStyle.Fill;
            lblRentedVehiclesCount.Font = new Font("Microsoft Sans Serif", 26F);
            lblRentedVehiclesCount.ForeColor = Color.Navy;
            lblRentedVehiclesCount.Location = new Point(0, 40);
            lblRentedVehiclesCount.Name = "lblRentedVehiclesCount";
            lblRentedVehiclesCount.Size = new Size(180, 90);
            lblRentedVehiclesCount.TabIndex = 3;
            lblRentedVehiclesCount.Text = "0";
            lblRentedVehiclesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomersCount
            // 
            lblTotalCustomersCount.BackColor = Color.Transparent;
            lblTotalCustomersCount.Dock = DockStyle.Fill;
            lblTotalCustomersCount.Font = new Font("Microsoft Sans Serif", 26F);
            lblTotalCustomersCount.ForeColor = Color.Navy;
            lblTotalCustomersCount.Location = new Point(0, 40);
            lblTotalCustomersCount.Name = "lblTotalCustomersCount";
            lblTotalCustomersCount.Size = new Size(180, 90);
            lblTotalCustomersCount.TabIndex = 4;
            lblTotalCustomersCount.Text = "0";
            lblTotalCustomersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveRentalsCount
            // 
            lblActiveRentalsCount.BackColor = Color.Transparent;
            lblActiveRentalsCount.Dock = DockStyle.Fill;
            lblActiveRentalsCount.Font = new Font("Microsoft Sans Serif", 26F);
            lblActiveRentalsCount.ForeColor = Color.Navy;
            lblActiveRentalsCount.Location = new Point(0, 40);
            lblActiveRentalsCount.Name = "lblActiveRentalsCount";
            lblActiveRentalsCount.Size = new Size(180, 90);
            lblActiveRentalsCount.TabIndex = 2;
            lblActiveRentalsCount.Text = "0";
            lblActiveRentalsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVehicleManagement
            // 
            btnVehicleManagement.BackColor = Color.SteelBlue;
            btnVehicleManagement.FlatStyle = FlatStyle.Flat;
            btnVehicleManagement.Font = new Font("Microsoft Sans Serif", 11F);
            btnVehicleManagement.ForeColor = Color.White;
            btnVehicleManagement.Location = new Point(100, 350);
            btnVehicleManagement.Name = "btnVehicleManagement";
            btnVehicleManagement.Size = new Size(200, 60);
            btnVehicleManagement.TabIndex = 2;
            btnVehicleManagement.Text = "ARAÇ YÖNETİMİ";
            btnVehicleManagement.UseVisualStyleBackColor = false;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.MediumSeaGreen;
            btnCustomerManagement.FlatStyle = FlatStyle.Flat;
            btnCustomerManagement.Font = new Font("Microsoft Sans Serif", 11F);
            btnCustomerManagement.ForeColor = Color.White;
            btnCustomerManagement.Location = new Point(320, 350);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(200, 60);
            btnCustomerManagement.TabIndex = 3;
            btnCustomerManagement.Text = "MÜŞTERİ YÖNETİMİ";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            // 
            // btnRentalManagement
            // 
            btnRentalManagement.BackColor = Color.DarkOrange;
            btnRentalManagement.FlatStyle = FlatStyle.Flat;
            btnRentalManagement.Font = new Font("Microsoft Sans Serif", 11F);
            btnRentalManagement.ForeColor = Color.White;
            btnRentalManagement.Location = new Point(540, 350);
            btnRentalManagement.Name = "btnRentalManagement";
            btnRentalManagement.Size = new Size(200, 60);
            btnRentalManagement.TabIndex = 4;
            btnRentalManagement.Text = "ARAÇ KİRALAMA";
            btnRentalManagement.UseVisualStyleBackColor = false;
            // 
            // btnVehicleReturn
            // 
            btnVehicleReturn.BackColor = Color.SlateBlue;
            btnVehicleReturn.FlatStyle = FlatStyle.Flat;
            btnVehicleReturn.Font = new Font("Microsoft Sans Serif", 11F);
            btnVehicleReturn.ForeColor = Color.White;
            btnVehicleReturn.Location = new Point(760, 350);
            btnVehicleReturn.Name = "btnVehicleReturn";
            btnVehicleReturn.Size = new Size(200, 60);
            btnVehicleReturn.TabIndex = 5;
            btnVehicleReturn.Text = "ARAÇ İADE";
            btnVehicleReturn.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(btnVehicleReturn);
            Controls.Add(btnRentalManagement);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnVehicleManagement);
            Controls.Add(pnlStatistics);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(900, 600);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kiralama Yönetim Sistemi";
            Load += DashboardForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlStatistics.ResumeLayout(false);
            pnlTotalVehicles.ResumeLayout(false);
            pnlAvailableVehicles.ResumeLayout(false);
            pnlRentedVehicles.ResumeLayout(false);
            pnlTotalCustomers.ResumeLayout(false);
            pnlActiveRentals.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlStatistics;
        private Panel pnlTotalVehicles;
        private Panel pnlTotalCustomers;
        private Panel pnlRentedVehicles;
        private Panel pnlAvailableVehicles;
        private Panel pnlActiveRentals;
        private Label lblAvailableVehiclesTitle;
        private Label lblTotalVehiclesTitle;
        private Label lblActiveRentalsTitle;
        private Label lblTotalCustomersTitle;
        private Label lblRentedVehiclesTitle;
        private Label lblTotalVehiclesCount;
        private Label lblActiveRentalsCount;
        private Label lblTotalCustomersCount;
        private Label lblRentedVehiclesCount;
        private Label lblAvailableVehiclesCount;
        private Button btnVehicleManagement;
        private Button btnCustomerManagement;
        private Button btnRentalManagement;
        private Button btnVehicleReturn;
    }
}