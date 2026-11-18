
using System;
using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services
{
    // Araç yönetimiyle ilgili işlemleri gerçekleştiren servis sınıfı.
    public class VehicleService
    {
        // Araçları bellekte saklamak için List koleksiyonu kullanılır.
        private readonly List<Vehicle> vehicles;

        // Constructor: Araç listesini başlangıçta oluşturur.
        public VehicleService()
        {
            vehicles = new List<Vehicle>();
        }

        // Sisteme yeni araç ekler.
        public void AddVehicle(Vehicle vehicle)
        {
            // Boş araç eklenmesi engellenir.
            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle));

            // Aynı plakaya sahip başka bir araç eklenemez.
            foreach (Vehicle existingVehicle in vehicles)
            {
                if (string.Equals(
                    existingVehicle.Plate,
                    vehicle.Plate,
                    StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException(
                        "Bu plakaya sahip bir araç zaten kayıtlı.");
                }
            }

            vehicles.Add(vehicle);
        }

        // Sistemde kayıtlı araçların listesini döndürür.
        // Yeni bir liste oluşturarak asıl koleksiyonun korunmasını sağlar.
        public List<Vehicle> GetAllVehicles()
        {
            return new List<Vehicle>(vehicles);
        }

        // Kayıtlı bir aracın bilgilerini günceller.
        public void UpdateVehicle(Vehicle updatedVehicle)
        {
            if (updatedVehicle == null)
                throw new ArgumentNullException(nameof(updatedVehicle));

            // Güncellenecek aracın listedeki konumu bulunur.
            int index = vehicles.FindIndex(
                vehicle => vehicle.Id == updatedVehicle.Id);

            if (index == -1)
                throw new InvalidOperationException(
                    "Güncellenecek araç bulunamadı.");

            // Başka bir araçla aynı plakanın kullanılmasını engeller.
            foreach (Vehicle existingVehicle in vehicles)
            {
                if (existingVehicle.Id != updatedVehicle.Id &&
                    string.Equals(
                        existingVehicle.Plate,
                        updatedVehicle.Plate,
                        StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException(
                        "Bu plaka başka bir araca kayıtlı.");
                }
            }

            // Mevcut araç nesnesini koruyarak bilgilerini güncelliyoruz.
            Vehicle currentVehicle = vehicles[index];

            currentVehicle.Plate = updatedVehicle.Plate;
            currentVehicle.Brand = updatedVehicle.Brand;
            currentVehicle.Model = updatedVehicle.Model;
            currentVehicle.Year = updatedVehicle.Year;
            currentVehicle.DailyRate = updatedVehicle.DailyRate;

            // Araç türü Car ise kapı sayısını da güncelliyoruz.
            if (currentVehicle is Car currentCar &&
                updatedVehicle is Car updatedCar)
            {
                currentCar.DoorCount = updatedCar.DoorCount;
            }
        }

        // Kiralama geçmişi bulunan araçların silinmesini engeller.
        public void DeleteVehicle(int vehicleId, List<Rental> rentalHistory)
        {
            if (rentalHistory == null)
                throw new ArgumentNullException(nameof(rentalHistory));

            // Aracın geçmişte herhangi bir kiralama kaydı olup olmadığı kontrol edilir.
            foreach (Rental rental in rentalHistory)
            {
                if (rental.Vehicle.Id == vehicleId)
                {
                    throw new InvalidOperationException(
                        "Kiralama geçmişi bulunan araç silinemez.");
                }
            }

            // Silinecek araç listede aranır.
            // Araç bulunamayabileceği için null kontrolü yapılır.
            Vehicle? vehicle = vehicles.Find(
                item => item.Id == vehicleId);

            if (vehicle == null)
                throw new InvalidOperationException(
                    "Silinecek araç bulunamadı.");

            // Araç listeden kaldırılır.
            vehicles.Remove(vehicle);
        }
    }
}
