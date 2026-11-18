
using System;
using System.Windows.Forms;
using WinFormsApp1.Services;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms
{
    public partial class VehicleReturnForm : Form
    {
        // Ana sistemdeki ortak servis nesnesi.
        private readonly RentalSystemService _systemService;

        public VehicleReturnForm(RentalSystemService systemService)
        {
            InitializeComponent();

            _systemService = systemService;

            // Form açıldığında aktif kiralamaları yükler.
            Load += VehicleReturnForm_Load;

            // İade butonuna tıklanınca iade işlemini başlatır.
            btnReturnVehicle.Click += btnReturnVehicle_Click;
        }

        // Aktif kiralamaları tabloya yükler.
        private void VehicleReturnForm_Load(object? sender, EventArgs e)
        {
            LoadActiveRentals();
        }

        private void LoadActiveRentals()
        {
            dgvActiveRentals.DataSource = null;
            dgvActiveRentals.DataSource = _systemService.GetActiveRentals();
        }

        // Seçili aracın iade işlemini gerçekleştirir.
        private void btnReturnVehicle_Click(object? sender, EventArgs e)
        {
            if (dgvActiveRentals.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iade etmek için aktif bir kiralama seçin.");
                return;
            }

            Rental? selectedRental =
                dgvActiveRentals.CurrentRow.DataBoundItem as Rental;

            if (selectedRental == null)
            {
                MessageBox.Show("Seçilen kiralama bilgileri alınamadı.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Seçili aracın iadesini onaylıyor musunuz?",
                "Araç İade Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                _systemService.ReturnVehicle(selectedRental.Id);

                LoadActiveRentals();

                MessageBox.Show("Araç başarıyla iade edildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç iade edilemedi: " + ex.Message);
            }
        }
    }
}
