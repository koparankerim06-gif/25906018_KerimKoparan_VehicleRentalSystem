
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Services;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms
{
    public partial class CustomerManagementForm : Form
    {
        // Ana sistemdeki ortak servis nesnesi.
        private readonly RentalSystemService _systemService;

        public CustomerManagementForm(RentalSystemService systemService)
        {
            InitializeComponent();

            _systemService = systemService;

            // Form açıldığında müşteri listesini yükler.
            Load += CustomerManagementForm_Load;

            // Tabloya tıklanınca müşteri bilgilerini kutulara aktarır.
            dgvCustomers.CellClick += dgvCustomers_CellClick;

            // İşlem butonlarının tıklama olayları.
            btnAddCustomer.Click += btnAddCustomer_Click;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            btnClearCustomer.Click += btnClearCustomer_Click;
        }

        private void CustomerManagementForm_Load(object? sender, EventArgs e)
        {
            LoadCustomers();
        }

        // Müşteri listesini tabloya yükler.
        private void LoadCustomers()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _systemService.CustomerService.GetAllCustomers();
        }

        // Yeni müşteri ekleme işlemi.
        private void btnAddCustomer_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                MessageBox.Show("Lütfen bütün müşteri bilgilerini doldurun.");
                return;
            }

            try
            {
                var customers = _systemService.CustomerService.GetAllCustomers();

                int newId = customers.Count == 0
                    ? 1
                    : customers.Max(customer => customer.Id) + 1;

                Customer newCustomer = new Customer(
                    newId,
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtLicenseNumber.Text.Trim()
                );

                _systemService.AddCustomer(newCustomer);

                LoadCustomers();
                ClearFields();

                MessageBox.Show("Müşteri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri eklenemedi: " + ex.Message);
            }
        }

        // Tabloda seçilen müşterinin bilgilerini kutulara aktarır.
        private void dgvCustomers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Customer? selectedCustomer =
                dgvCustomers.Rows[e.RowIndex].DataBoundItem as Customer;

            if (selectedCustomer == null)
                return;

            txtFirstName.Text = selectedCustomer.FirstName;
            txtLastName.Text = selectedCustomer.LastName;
            txtPhone.Text = selectedCustomer.Phone;
            txtLicenseNumber.Text = selectedCustomer.LicenseNumber;
        }

        // Mevcut müşteri bilgilerini güncelleme işlemi.
        private void btnUpdateCustomer_Click(object? sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için tablodan müşteri seçin.");
                return;
            }

            Customer? selectedCustomer =
                dgvCustomers.CurrentRow.DataBoundItem as Customer;

            if (selectedCustomer == null)
            {
                MessageBox.Show("Seçilen müşteri bulunamadı.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                MessageBox.Show("Lütfen bütün müşteri bilgilerini doldurun.");
                return;
            }

            try
            {
                Customer updatedCustomer = new Customer(
                    selectedCustomer.Id,
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtLicenseNumber.Text.Trim()
                );

                _systemService.UpdateCustomer(updatedCustomer);

                LoadCustomers();
                ClearFields();

                MessageBox.Show("Müşteri başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri güncellenemedi: " + ex.Message);
            }
        }

        // Seçili müşteriyi silme işlemi.
        private void btnDeleteCustomer_Click(object? sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için tablodan müşteri seçin.");
                return;
            }

            Customer? selectedCustomer =
                dgvCustomers.CurrentRow.DataBoundItem as Customer;

            if (selectedCustomer == null)
            {
                MessageBox.Show("Seçilen müşteri bulunamadı.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Seçili müşteriyi silmek istediğinizden emin misiniz?",
                "Müşteri Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                _systemService.DeleteCustomer(selectedCustomer.Id);

                LoadCustomers();
                ClearFields();

                MessageBox.Show("Müşteri başarıyla silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri silinemedi: " + ex.Message);
            }
        }

        // Müşteri giriş kutularını temizler.
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtLicenseNumber.Clear();
        }

        // Temizle butonunun işlemi.
        private void btnClearCustomer_Click(object? sender, EventArgs e)
        {
            ClearFields();
            dgvCustomers.ClearSelection();

            MessageBox.Show("Giriş alanları temizlendi.");
        }
    }
}
