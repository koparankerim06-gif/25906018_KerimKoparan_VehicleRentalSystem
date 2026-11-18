
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Services;

namespace WinFormsApp1.Forms
{
    public partial class RentalManagementForm : Form
    {
        // Ana servis nesnesine erişim sağlar.
        private readonly RentalSystemService _systemService;

        // Constructor: Form ve servis bağlantısını oluşturur.
        public RentalManagementForm(RentalSystemService systemService)
        {
            InitializeComponent();

            _systemService = systemService;

            // Form açıldığında listeleri ve kiralamaları yükler.
            Load += RentalManagementForm_Load;

            // Seçimler ve tarihler değiştiğinde ücreti hesaplar.
            cmbVehicles.SelectedIndexChanged += SelectionChanged;
            dtpStartDate.ValueChanged += SelectionChanged;
            dtpEndDate.ValueChanged += SelectionChanged;

            // Kiralama oluşturma butonunu bağlar.
            btnCreateRental.Click += btnCreateRental_Click;
        }

        // Form açıldığında gerekli verileri yükler.
        private void RentalManagementForm_Load(object? sender, EventArgs e)
        {
            LoadCustomers();
            LoadVehicles();
            LoadRentals();
            CalculateTotalPrice();
        }

        // Müşteri listesini ComboBox'a yükler.
        private void LoadCustomers()
        {
            cmbCustomers.DataSource = null;
            cmbCustomers.DataSource =
                _systemService.CustomerService.GetAllCustomers();

            cmbCustomers.DisplayMember = "FirstName";
            cmbCustomers.ValueMember = "Id";
        }

        // Yalnızca müsait araçları ComboBox'a yükler.
        private void LoadVehicles()
        {
            cmbVehicles.DataSource = null;

            var availableVehicles = _systemService.GetAllVehicles()
                .Where(vehicle => vehicle.IsAvailable())
                .ToList();

            cmbVehicles.DataSource = availableVehicles;
            cmbVehicles.DisplayMember = "Plate";
            cmbVehicles.ValueMember = "Id";
        }

        // Kiralama tablosunu yeniler.
        private void LoadRentals()
        {
            dgvRentals.DataSource = null;
            dgvRentals.DataSource =
                _systemService.RentalService.GetAllRentals();
        }

        // Başlangıç ve bitiş tarihlerine göre kiralama gününü hesaplar.
        // Aynı gün kiralama en az 1 gün kabul edilir.
        private int CalculateRentalDays()
        {
            int days =
                (dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days;

            if (days == 0)
                return 1;

            return days;
        }

        // Seçilen araç ve tarihlere göre toplam ücreti hesaplar.
        private void CalculateTotalPrice()
        {
            if (cmbVehicles.SelectedItem is not Vehicle selectedVehicle)
            {
                lblTotalPrice.Text = "0,00 TL";
                return;
            }

            // Bitiş tarihi başlangıç tarihinden önce olamaz.
            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                lblTotalPrice.Text = "Geçersiz tarih";
                return;
            }

            int days = CalculateRentalDays();

            decimal totalPrice =
                selectedVehicle.CalculateRentalPrice(days);

            lblTotalPrice.Text = totalPrice.ToString("N2") + " TL";
        }

        // Seçim veya tarih değiştiğinde ücreti yeniden hesaplar.
        private void SelectionChanged(object? sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        // Seçilen müşteri ve araç için kiralama oluşturur.
        private void btnCreateRental_Click(object? sender, EventArgs e)
        {
            try
            {
                // Müşteri seçimi kontrol edilir.
                if (cmbCustomers.SelectedItem is not Customer selectedCustomer)
                {
                    MessageBox.Show("Lütfen bir müşteri seçin.");
                    return;
                }

                // Araç seçimi kontrol edilir.
                if (cmbVehicles.SelectedItem is not Vehicle selectedVehicle)
                {
                    MessageBox.Show("Lütfen müsait bir araç seçin.");
                    return;
                }

                // Bitiş tarihi başlangıç tarihinden önce olamaz.
                if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
                {
                    MessageBox.Show(
                        "Bitiş tarihi başlangıç tarihinden önce olamaz.");
                    return;
                }

                // Yeni kiralama için benzersiz ID oluşturulur.
                int rentalId = _systemService.RentalService.GetAllRentals()
                    .Select(rental => rental.Id)
                    .DefaultIfEmpty(0)
                    .Max() + 1;

                // Kiralama işlemi gerçekleştirilir.
                _systemService.CreateRental(
                    rentalId,
                    selectedCustomer,
                    selectedVehicle,
                    dtpStartDate.Value.Date,
                    dtpEndDate.Value.Date
                );

                MessageBox.Show(
                    "Kiralama başarıyla oluşturuldu.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Araç ve kiralama listeleri yenilenir.
                LoadVehicles();
                LoadRentals();
                CalculateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kiralama oluşturulamadı: " + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                LoadVehicles();
                CalculateTotalPrice();
            }
        }
    }
}
