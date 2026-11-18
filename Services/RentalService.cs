
using System;
using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services
{
    // Araç kiralama ve iade işlemlerini yöneten servis sınıfı.
    public class RentalService
    {
        // Kiralama kayıtlarını bellekte saklayan private liste.
        private readonly List<Rental> rentals;

        // Constructor: Kiralama listesini oluşturur.
        public RentalService()
        {
            rentals = new List<Rental>();
        }

        // Yeni bir kiralama işlemi gerçekleştirir.
        public Rental CreateRental(
            int rentalId,
            Customer customer,
            Vehicle vehicle,
            DateTime startDate,
            DateTime endDate)
        {
            // Kiralama ID'sinin pozitif olması gerekir.
            if (rentalId <= 0)
                throw new ArgumentException(
                    "Kiralama ID pozitif olmalıdır.");

            // Müşteri ve araç bilgileri boş bırakılamaz.
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle));

            // Aynı kiralama ID'sinin tekrar kullanılmasını engeller.
            foreach (Rental existingRental in rentals)
            {
                if (existingRental.Id == rentalId)
                    throw new InvalidOperationException(
                        "Bu kiralama ID'si zaten kullanılıyor.");
            }

            // Rental nesnesi oluşturulur.
            // Constructor tarihleri, araç durumunu ve ücreti kontrol eder.
            Rental rental = new Rental(
                rentalId,
                customer,
                vehicle,
                startDate,
                endDate);

            // Oluşturulan kiralama kaydı listeye eklenir.
            rentals.Add(rental);

            return rental;
        }

        // Sistemdeki tüm kiralama kayıtlarını döndürür.
        public List<Rental> GetAllRentals()
        {
            return new List<Rental>(rentals);
        }

        // Yalnızca devam eden kiralamaları listeler.
        public List<Rental> GetActiveRentals()
        {
            List<Rental> activeRentals = new List<Rental>();

            foreach (Rental rental in rentals)
            {
                if (rental.Status == RentalStatus.Active)
                {
                    activeRentals.Add(rental);
                }
            }

            return activeRentals;
        }

        // Araç iade işlemini gerçekleştirir.
        public void ReturnVehicle(int rentalId)
        {
            // İade edilecek kiralama kaydı bulunur.
            Rental? rental = rentals.Find(
                item => item.Id == rentalId);

            if (rental == null)
                throw new InvalidOperationException(
                    "İade edilecek kiralama kaydı bulunamadı.");

            // Kiralama tamamlanır ve araç müsait duruma getirilir.
            rental.CompleteRental();
        }

        // Belirli bir müşterinin kiralama geçmişini döndürür.
        public List<Rental> GetRentalsByCustomer(int customerId)
        {
            List<Rental> customerRentals = new List<Rental>();

            foreach (Rental rental in rentals)
            {
                if (rental.Customer.Id == customerId)
                {
                    customerRentals.Add(rental);
                }
            }

            return customerRentals;
        }

        // Belirli bir aracın kiralama geçmişini döndürür.
        public List<Rental> GetRentalsByVehicle(int vehicleId)
        {
            List<Rental> vehicleRentals = new List<Rental>();

            foreach (Rental rental in rentals)
            {
                if (rental.Vehicle.Id == vehicleId)
                {
                    vehicleRentals.Add(rental);
                }
            }

            return vehicleRentals;
        }
    }
}
