
using System;
using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services
{
    // Uygulamadaki bütün servisleri tek merkezden yöneten ana sınıf.
    public class RentalSystemService
    {
        // Servis nesneleri yalnızca constructor içerisinde atanabilir.
        private readonly VehicleService vehicleService;
        private readonly CustomerService customerService;
        private readonly RentalService rentalService;

        // Servislere kontrollü erişim sağlayan property'ler.
        public VehicleService VehicleService
        {
            get { return vehicleService; }
        }

        public CustomerService CustomerService
        {
            get { return customerService; }
        }

        public RentalService RentalService
        {
            get { return rentalService; }
        }

        // Constructor: Servis nesnelerini oluşturur.
        public RentalSystemService()
        {
            vehicleService = new VehicleService();
            customerService = new CustomerService();
            rentalService = new RentalService();
        }

        // Yeni araç ekleme işlemi.
        public void AddVehicle(Vehicle vehicle)
        {
            VehicleService.AddVehicle(vehicle);
        }

        // Mevcut aracın bilgilerini günceller.
        public void UpdateVehicle(Vehicle vehicle)
        {
            VehicleService.UpdateVehicle(vehicle);
        }

        // Sistemdeki bütün araçları listeler.
        public List<Vehicle> GetAllVehicles()
        {
            return VehicleService.GetAllVehicles();
        }

        // Yeni müşteri ekleme işlemi.
        public void AddCustomer(Customer customer)
        {
            CustomerService.AddCustomer(customer);
        }

        // Mevcut müşterinin bilgilerini günceller.
        public void UpdateCustomer(Customer customer)
        {
            CustomerService.UpdateCustomer(customer);
        }

        // Sistemdeki bütün müşterileri listeler.
        public List<Customer> GetAllCustomers()
        {
            return CustomerService.GetAllCustomers();
        }

        // Yeni kiralama işlemi.
        public Rental CreateRental(
            int rentalId,
            Customer customer,
            Vehicle vehicle,
            DateTime startDate,
            DateTime endDate)
        {
            return RentalService.CreateRental(
                rentalId,
                customer,
                vehicle,
                startDate,
                endDate);
        }

        // Sistemdeki bütün kiralamaları listeler.
        public List<Rental> GetAllRentals()
        {
            return RentalService.GetAllRentals();
        }

        // Henüz iade edilmemiş kiralamaları listeler.
        public List<Rental> GetActiveRentals()
        {
            return RentalService.GetActiveRentals();
        }

        // Araç iade işlemi.
        public void ReturnVehicle(int rentalId)
        {
            RentalService.ReturnVehicle(rentalId);
        }

        // Araç silme işleminde kiralama geçmişini kontrol eder.
        public void DeleteVehicle(int vehicleId)
        {
            VehicleService.DeleteVehicle(
                vehicleId,
                RentalService.GetAllRentals());
        }

        // Müşteri silme işleminde aktif kiralamaları kontrol eder.
        public void DeleteCustomer(int customerId)
        {
            CustomerService.DeleteCustomer(
                customerId,
                RentalService.GetAllRentals());
        }
    }
}
