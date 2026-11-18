
using System;

namespace WinFormsApp1.Models
{
    // Car sınıfı Vehicle sınıfından miras alır.
    // Böylece aracın ortak özelliklerini ve metotlarını kullanabilir.
    public class Car : Vehicle
    {
        // Otomobilin kapı sayısını tutan private alan.
        private int doorCount;

        // Kapı sayısına kontrollü erişim sağlayan property.
        public int DoorCount
        {
            get { return doorCount; }
            set
            {
                // Otomobiller için kapı sayısı 2 ile 5 arasında olmalıdır.
                if (value < 2 || value > 5)
                    throw new ArgumentOutOfRangeException(
                        nameof(DoorCount),
                        "Kapı sayısı 2 ile 5 arasında olmalıdır.");

                doorCount = value;
            }
        }

        // Constructor: Otomobil oluşturulurken araç bilgilerini alır.
        // base ifadesi ile Vehicle sınıfının constructor'ı çağrılır.
        public Car(
            int id,
            string plate,
            string brand,
            string model,
            int year,
            decimal dailyRate,
            int doorCount)
            : base(id, plate, brand, model, year, dailyRate)
        {
            // Kapı sayısı property üzerinden doğrulanarak atanır.
            DoorCount = doorCount;
        }

        // Polymorphism: Vehicle sınıfındaki abstract metot override edilir.
        // Kiralama bedeli gün sayısı ile günlük ücretin çarpılmasıyla hesaplanır.
        public override decimal CalculateRentalPrice(int days)
        {
            // Kiralama süresi en az 1 gün olmalıdır.
            if (days <= 0)
                throw new ArgumentException(
                    "Kiralama süresi en az 1 gün olmalıdır.");

            return DailyRate * days;
        }
    }
}
