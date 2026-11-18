namespace WinFormsApp1.Forms
{
    partial class VehicleReturnForm
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
            dgvActiveRentals = new DataGridView();
            btnReturnVehicle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActiveRentals).BeginInit();
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
            lblFormTitle.Text = "ARAÇ İADE";
            // 
            // dgvActiveRentals
            // 
            dgvActiveRentals.AllowUserToAddRows = false;
            dgvActiveRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveRentals.Location = new Point(30, 120);
            dgvActiveRentals.MultiSelect = false;
            dgvActiveRentals.Name = "dgvActiveRentals";
            dgvActiveRentals.ReadOnly = true;
            dgvActiveRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveRentals.Size = new Size(820, 400);
            dgvActiveRentals.TabIndex = 1;
            // 
            // btnReturnVehicle
            // 
            btnReturnVehicle.BackColor = Color.SeaGreen;
            btnReturnVehicle.FlatStyle = FlatStyle.Flat;
            btnReturnVehicle.Font = new Font("Microsoft Sans Serif", 11F);
            btnReturnVehicle.ForeColor = Color.White;
            btnReturnVehicle.Location = new Point(30, 550);
            btnReturnVehicle.Name = "btnReturnVehicle";
            btnReturnVehicle.Size = new Size(180, 45);
            btnReturnVehicle.TabIndex = 2;
            btnReturnVehicle.Text = "İADE ET";
            btnReturnVehicle.UseVisualStyleBackColor = false;
            // 
            // VehicleReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            Controls.Add(btnReturnVehicle);
            Controls.Add(dgvActiveRentals);
            Controls.Add(lblFormTitle);
            MaximumSize = new Size(900, 650);
            Name = "VehicleReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARAÇ İADE";
            ((System.ComponentModel.ISupportInitialize)dgvActiveRentals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFormTitle;
        private DataGridView dgvActiveRentals;
        private Button btnReturnVehicle;
    }
}