
using System;
using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services
{
    // Müşteri yönetimiyle ilgili işlemleri gerçekleştiren servis sınıfı.
    public class CustomerService
    {
        // Müşterileri bellekte saklamak için private readonly liste.
        private readonly List<Customer> customers;

        // Constructor: Müşteri listesini oluşturur.
        public CustomerService()
        {
            customers = new List<Customer>();
        }

        // Sisteme yeni müşteri ekler.
        public void AddCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            // Aynı ID ile ikinci müşteri eklenmesini engeller.
            foreach (Customer existingCustomer in customers)
            {
                if (existingCustomer.Id == customer.Id)
                    throw new InvalidOperationException(
                        "Bu müşteri ID'si zaten kayıtlı.");

                // Aynı ehliyet numarasıyla ikinci kayıt oluşturulamaz.
                if (string.Equals(
                    existingCustomer.LicenseNumber,
                    customer.LicenseNumber,
                    StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException(
                        "Bu ehliyet numarasıyla kayıtlı bir müşteri zaten var.");
                }
            }

            customers.Add(customer);
        }

        // Sistemde kayıtlı tüm müşterileri döndürür.
        public List<Customer> GetAllCustomers()
        {
            // Asıl listeyi korumak için kopyası döndürülür.
            return new List<Customer>(customers);
        }

        // Kayıtlı bir müşterinin bilgilerini günceller.
        public void UpdateCustomer(Customer updatedCustomer)
        {
            if (updatedCustomer == null)
                throw new ArgumentNullException(nameof(updatedCustomer));

            // Güncellenecek müşterinin listedeki konumu bulunur.
            int index = customers.FindIndex(
                customer => customer.Id == updatedCustomer.Id);

            if (index == -1)
                throw new InvalidOperationException(
                    "Güncellenecek müşteri bulunamadı.");

            // Başka bir müşterinin ehliyet numarası kullanılamaz.
            foreach (Customer existingCustomer in customers)
            {
                if (existingCustomer.Id != updatedCustomer.Id &&
                    string.Equals(
                        existingCustomer.LicenseNumber,
                        updatedCustomer.LicenseNumber,
                        StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException(
                        "Bu ehliyet numarası başka bir müşteriye kayıtlı.");
                }
            }

            // Mevcut müşteri nesnesi korunarak bilgileri güncellenir.
            Customer currentCustomer = customers[index];

            currentCustomer.FirstName = updatedCustomer.FirstName;
            currentCustomer.LastName = updatedCustomer.LastName;
            currentCustomer.Phone = updatedCustomer.Phone;
            currentCustomer.LicenseNumber = updatedCustomer.LicenseNumber;
        }

        // Aktif kiralaması bulunan müşterilerin silinmesini engeller.
        public void DeleteCustomer(
            int customerId,
            List<Rental> rentalHistory)
        {
            if (rentalHistory == null)
                throw new ArgumentNullException(nameof(rentalHistory));

            // Müşterinin aktif kiralaması olup olmadığı kontrol edilir.
            foreach (Rental rental in rentalHistory)
            {
                if (rental.Customer.Id == customerId &&
                    rental.Status == RentalStatus.Active)
                {
                    throw new InvalidOperationException(
                        "Aktif kiralaması bulunan müşteri silinemez.");
                }
            }

            // Silinecek müşteri listede aranır.
            Customer? customer = customers.Find(
                item => item.Id == customerId);

            if (customer == null)
                throw new InvalidOperationException(
                    "Silinecek müşteri bulunamadı.");

            // Müşteri listeden kaldırılır.
            customers.Remove(customer);
        }
    }
}
