namespace WinFormsApp1.Forms
{
    partial class VehicleManagementForm
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
            dgvVehicles = new DataGridView();
            lblFormTitle = new Label();
            lblPlate = new Label();
            txtPlate = new TextBox();
            lblBrand = new Label();
            txtBrand = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblYear = new Label();
            txtYear = new TextBox();
            lblDailyRate = new Label();
            txtDailyRate = new TextBox();
            lblDoorCount = new Label();
            txtDoorCount = new TextBox();
            btnAddVehicle = new Button();
            btnUpdateVehicle = new Button();
            btnDeleteVehicle = new Button();
            btnClearVehicle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Location = new Point(30, 250);
            dgvVehicles.MultiSelect = false;
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.Size = new Size(920, 300);
            dgvVehicles.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 18F);
            lblFormTitle.ForeColor = Color.SteelBlue;
            lblFormTitle.Location = new Point(30, 20);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(400, 45);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "ARAÇ YÖNETİMİ";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(30, 90);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(38, 15);
            lblPlate.TabIndex = 2;
            lblPlate.Text = "Plaka:";
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(83, 87);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(180, 23);
            txtPlate.TabIndex = 3;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(320, 90);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(43, 15);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "Marka:";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(386, 87);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(180, 23);
            txtBrand.TabIndex = 5;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(30, 140);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(110, 135);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(180, 23);
            txtModel.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(320, 140);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(65, 15);
            lblYear.TabIndex = 9;
            lblYear.Text = "Üretim Yılı:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(409, 135);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(171, 23);
            txtYear.TabIndex = 10;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Location = new Point(30, 190);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(79, 15);
            lblDailyRate.TabIndex = 11;
            lblDailyRate.Text = "Günlük Ücret:";
            // 
            // txtDailyRate
            // 
            txtDailyRate.Location = new Point(130, 185);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(180, 23);
            txtDailyRate.TabIndex = 12;
            // 
            // lblDoorCount
            // 
            lblDoorCount.AutoSize = true;
            lblDoorCount.Location = new Point(320, 190);
            lblDoorCount.Name = "lblDoorCount";
            lblDoorCount.Size = new Size(65, 15);
            lblDoorCount.TabIndex = 13;
            lblDoorCount.Text = "Kapı Sayısı:";
            // 
            // txtDoorCount
            // 
            txtDoorCount.Location = new Point(420, 185);
            txtDoorCount.Name = "txtDoorCount";
            txtDoorCount.Size = new Size(180, 23);
            txtDoorCount.TabIndex = 14;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.BackColor = Color.SeaGreen;
            btnAddVehicle.FlatStyle = FlatStyle.Flat;
            btnAddVehicle.ForeColor = Color.White;
            btnAddVehicle.Location = new Point(650, 90);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(130, 40);
            btnAddVehicle.TabIndex = 15;
            btnAddVehicle.Text = "ARAÇ EKLE";
            btnAddVehicle.UseVisualStyleBackColor = false;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // btnUpdateVehicle
            // 
            btnUpdateVehicle.BackColor = Color.DarkOrange;
            btnUpdateVehicle.FlatStyle = FlatStyle.Flat;
            btnUpdateVehicle.ForeColor = Color.White;
            btnUpdateVehicle.Location = new Point(650, 140);
            btnUpdateVehicle.Name = "btnUpdateVehicle";
            btnUpdateVehicle.Size = new Size(130, 40);
            btnUpdateVehicle.TabIndex = 16;
            btnUpdateVehicle.Text = "GÜNCELLE";
            btnUpdateVehicle.UseVisualStyleBackColor = false;
            btnUpdateVehicle.Click += btnUpdateVehicle_Click;
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.BackColor = Color.IndianRed;
            btnDeleteVehicle.FlatStyle = FlatStyle.Flat;
            btnDeleteVehicle.ForeColor = Color.White;
            btnDeleteVehicle.Location = new Point(800, 90);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(130, 40);
            btnDeleteVehicle.TabIndex = 17;
            btnDeleteVehicle.Text = "SİL";
            btnDeleteVehicle.UseVisualStyleBackColor = false;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // btnClearVehicle
            // 
            btnClearVehicle.BackColor = Color.DimGray;
            btnClearVehicle.FlatStyle = FlatStyle.Flat;
            btnClearVehicle.ForeColor = Color.White;
            btnClearVehicle.Location = new Point(800, 140);
            btnClearVehicle.Name = "btnClearVehicle";
            btnClearVehicle.Size = new Size(130, 40);
            btnClearVehicle.TabIndex = 18;
            btnClearVehicle.Text = "TEMİZLE";
            btnClearVehicle.UseVisualStyleBackColor = false;
            btnClearVehicle.Click += btnClearVehicle_Click;
            // 
            // VehicleManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnClearVehicle);
            Controls.Add(btnDeleteVehicle);
            Controls.Add(btnUpdateVehicle);
            Controls.Add(btnAddVehicle);
            Controls.Add(txtDoorCount);
            Controls.Add(lblDoorCount);
            Controls.Add(txtDailyRate);
            Controls.Add(lblDailyRate);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtBrand);
            Controls.Add(lblBrand);
            Controls.Add(txtPlate);
            Controls.Add(lblPlate);
            Controls.Add(lblFormTitle);
            Controls.Add(dgvVehicles);
            MinimumSize = new Size(900, 600);
            Name = "VehicleManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARAÇ YÖNETİMİ";
            Load += VehicleManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVehicles;
        private Label lblFormTitle;
        private Label lblPlate;
        private TextBox txtPlate;
        private Label lblBrand;
        private TextBox txtBrand;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblDailyRate;
        private TextBox txtDailyRate;
        private Label lblDoorCount;
        private TextBox txtDoorCount;
        private Button btnAddVehicle;
        private Button btnUpdateVehicle;
        private Button btnDeleteVehicle;
        private Button btnClearVehicle;
    }
}