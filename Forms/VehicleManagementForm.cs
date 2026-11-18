
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Services;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms
{
    public partial class VehicleManagementForm : Form
    {
        // Ana sistemdeki ortak servis nesnesi.
        private readonly RentalSystemService _systemService;

        public VehicleManagementForm(RentalSystemService systemService)
        {
            InitializeComponent();

            // Ortak servis bağlantısını alıyoruz.
            _systemService = systemService;

            // Form açıldığında araçları yükler.
            Load += VehicleManagementForm_Load;

            // Tabloya tıklanınca araç bilgilerini kutulara aktarır.
            dgvVehicles.CellClick += dgvVehicles_CellClick;
        }

        private void VehicleManagementForm_Load(object? sender, EventArgs e)
        {
            LoadVehicles();
        }

        // Araç listesini tabloya yükler.
        private void LoadVehicles()
        {
            dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = _systemService.GetAllVehicles();
        }

        // Araç girişlerini kontrol eder.
        private bool ValidateVehicleInputs(
            out int year,
            out decimal dailyRate,
            out int doorCount)
        {
            year = 0;
            dailyRate = 0;
            doorCount = 0;

            if (string.IsNullOrWhiteSpace(txtPlate.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Lütfen plaka, marka ve model bilgilerini doldurun.");
                return false;
            }

            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Üretim yılı sayısal olmalıdır.");
                return false;
            }

            if (year < 1886 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Üretim yılı 1886 ile içinde bulunduğumuz yıl arasında olmalıdır.");
                return false;
            }

            if (!decimal.TryParse(txtDailyRate.Text, out dailyRate))
            {
                MessageBox.Show("Günlük ücret sayısal olmalıdır.");
                return false;
            }

            if (dailyRate <= 0)
            {
                MessageBox.Show("Günlük ücret sıfırdan büyük olmalıdır.");
                return false;
            }

            if (!int.TryParse(txtDoorCount.Text, out doorCount))
            {
                MessageBox.Show("Kapı sayısı sayısal olmalıdır.");
                return false;
            }

            if (doorCount < 2 || doorCount > 5)
            {
                MessageBox.Show("Kapı sayısı 2 ile 5 arasında olmalıdır.");
                return false;
            }

            return true;
        }

        // Yeni araç ekleme işlemi.
        private void btnAddVehicle_Click(object? sender, EventArgs e)
        {
            if (!ValidateVehicleInputs(
                out int year,
                out decimal dailyRate,
                out int doorCount))
            {
                return;
            }

            try
            {
                var vehicles = _systemService.GetAllVehicles();

                int newId = vehicles.Count == 0
                    ? 1
                    : vehicles.Max(vehicle => vehicle.Id) + 1;

                Car newCar = new Car(
                    newId,
                    txtPlate.Text.Trim(),
                    txtBrand.Text.Trim(),
                    txtModel.Text.Trim(),
                    year,
                    dailyRate,
                    doorCount
                );

                _systemService.AddVehicle(newCar);

                LoadVehicles();
                ClearFields();

                MessageBox.Show("Araç başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç eklenemedi: " + ex.Message);
            }
        }

        // Mevcut araç bilgilerini güncelleme işlemi.
        private void btnUpdateVehicle_Click(object? sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için tablodan bir araç seçin.");
                return;
            }

            Vehicle? selectedVehicle =
                dgvVehicles.CurrentRow.DataBoundItem as Vehicle;

            if (selectedVehicle == null)
            {
                MessageBox.Show("Seçilen araç bilgileri alınamadı.");
                return;
            }

            if (!ValidateVehicleInputs(
                out int year,
                out decimal dailyRate,
                out int doorCount))
            {
                return;
            }

            try
            {
                Car updatedCar = new Car(
                    selectedVehicle.Id,
                    txtPlate.Text.Trim(),
                    txtBrand.Text.Trim(),
                    txtModel.Text.Trim(),
                    year,
                    dailyRate,
                    doorCount
                );

                _systemService.UpdateVehicle(updatedCar);

                LoadVehicles();
                ClearFields();

                MessageBox.Show("Araç başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç güncellenemedi: " + ex.Message);
            }
        }

        // Tabloda bir araca tıklanınca bilgilerini kutulara aktarır.
        private void dgvVehicles_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Vehicle? selectedVehicle =
                dgvVehicles.Rows[e.RowIndex].DataBoundItem as Vehicle;

            if (selectedVehicle == null)
                return;

            txtPlate.Text = selectedVehicle.Plate;
            txtBrand.Text = selectedVehicle.Brand;
            txtModel.Text = selectedVehicle.Model;
            txtYear.Text = selectedVehicle.Year.ToString();
            txtDailyRate.Text = selectedVehicle.DailyRate.ToString();

            if (selectedVehicle is Car selectedCar)
            {
                txtDoorCount.Text = selectedCar.DoorCount.ToString();
            }
        }

        // Seçili aracı silme işlemi.
        private void btnDeleteVehicle_Click(object? sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için tablodan bir araç seçin.");
                return;
            }

            Vehicle? selectedVehicle =
                dgvVehicles.CurrentRow.DataBoundItem as Vehicle;

            if (selectedVehicle == null)
            {
                MessageBox.Show("Seçilen araç bulunamadı.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Seçili aracı silmek istediğinizden emin misiniz?",
                "Araç Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                _systemService.DeleteVehicle(selectedVehicle.Id);

                LoadVehicles();
                ClearFields();

                MessageBox.Show("Araç başarıyla silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç silinemedi: " + ex.Message);
            }
        }

        // Araç giriş kutularını temizler.
        private void ClearFields()
        {
            txtPlate.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtDailyRate.Clear();
            txtDoorCount.Clear();
        }

        // Temizle butonunun işlemi.
        private void btnClearVehicle_Click(object? sender, EventArgs e)
        {
            ClearFields();
            dgvVehicles.ClearSelection();

            MessageBox.Show("Giriş alanları temizlendi.");
        }
    }
}
