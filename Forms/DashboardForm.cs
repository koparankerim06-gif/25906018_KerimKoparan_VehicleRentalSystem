
using System;
using System.Windows.Forms;
using System.Linq;
using WinFormsApp1.Models;
using WinFormsApp1.Services;

namespace WinFormsApp1.Forms
{
    public partial class DashboardForm : Form
    {
        // Tüm ekranların ortak kullanacağı servis nesnesi.
        private readonly RentalSystemService _systemService;

        public DashboardForm(RentalSystemService systemService)
        {
            InitializeComponent();

            _systemService = systemService;

            // Form açıldığında sayaçları günceller.
            Load += DashboardForm_Load;

            // Menü butonlarının tıklama olaylarını bağlıyoruz.
            btnVehicleManagement.Click += btnVehicleManagement_Click;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            btnRentalManagement.Click += btnRentalManagement_Click;
            btnVehicleReturn.Click += btnVehicleReturn_Click;
        }

        // Dashboard açıldığında sayaçları hesaplar.
        private void DashboardForm_Load(object? sender, EventArgs e)
        {
            UpdateDashboardCounts();
        }

        // Sayaçları gerçek verilere göre günceller.
        private void UpdateDashboardCounts()
        {
            var vehicles = _systemService.GetAllVehicles();
            var customers = _systemService.GetAllCustomers();
            var activeRentals = _systemService.GetActiveRentals();

            int availableCount = 0;
            int rentedCount = 0;

            // Araçların durumlarını tek tek kontrol eder.
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Status == VehicleStatus.Available)
                {
                    availableCount++;
                }
                else if (vehicle.Status == VehicleStatus.Rented)
                {
                    rentedCount++;
                }
            }

            lblTotalVehiclesCount.Text = vehicles.Count.ToString();
            lblAvailableVehiclesCount.Text = availableCount.ToString();
            lblRentedVehiclesCount.Text = rentedCount.ToString();
            lblTotalCustomersCount.Text = customers.Count.ToString();
            lblActiveRentalsCount.Text = activeRentals.Count.ToString();
        }

        // Araç yönetimi ekranını açar.
        private void btnVehicleManagement_Click(object? sender, EventArgs e)
        {
            VehicleManagementForm vehicleForm =
                new VehicleManagementForm(_systemService);

            vehicleForm.ShowDialog();
            UpdateDashboardCounts();
        }

        // Müşteri yönetimi ekranını açar.
        private void btnCustomerManagement_Click(object? sender, EventArgs e)
        {
            CustomerManagementForm customerForm =
                new CustomerManagementForm(_systemService);

            customerForm.ShowDialog();
            UpdateDashboardCounts();
        }

        // Araç kiralama ekranını açar.
        private void btnRentalManagement_Click(object? sender, EventArgs e)
        {
            RentalManagementForm rentalForm =
                new RentalManagementForm(_systemService);

            rentalForm.ShowDialog();
            UpdateDashboardCounts();
        }

        // Araç iade ekranını açar.
        private void btnVehicleReturn_Click(object? sender, EventArgs e)
        {
            VehicleReturnForm returnForm =
                new VehicleReturnForm(_systemService);

            returnForm.ShowDialog();
            UpdateDashboardCounts();
        }
    }
}
