
using System;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models
{
    // Araçların kiralama durumlarını belirlemek için kullanılan enum.
    public enum VehicleStatus
    {
        Available, // Araç kiralanmaya uygun.
        Rented     // Araç şu anda kirada.
    }

    // Abstract sınıf: Tüm araç türlerinin ortak özelliklerini ve davranışlarını tanımlar.
    // Abstraction ve inheritance kavramlarının temelini oluşturur.
    // Vehicle sınıfı IRentable arayüzünü uygulayarak kiralama sözleşmesini yerine getirir.
    public abstract class Vehicle : IRentable
    {
        // Encapsulation: Alanlar dışarıdan doğrudan erişime kapatılmıştır.
        private int id;
        private string plate = string.Empty;
        private string brand = string.Empty;
        private string model = string.Empty;
        private int year;
        private decimal dailyRate;

        // Aracın benzersiz kimlik numarası.
        // ID yalnızca constructor üzerinden atanır.
        public int Id
        {
            get { return id; }
        }

        // Aracın plakası. Boş girilmesi engellenir.
        // Plaka büyük harfe dönüştürülerek standartlaştırılır.
        public string Plate
        {
            get { return plate; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Plaka boş bırakılamaz.");

                plate = value.Trim().ToUpperInvariant();
            }
        }

        // Aracın markası. Boş değer kabul edilmez.
        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Marka boş bırakılamaz.");

                brand = value.Trim();
            }
        }

        // Aracın modeli. Boş değer kabul edilmez.
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Model boş bırakılamaz.");

                model = value.Trim();
            }
        }

        // Üretim yılı. Geçerli bir yıl aralığı kontrol edilir.
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1886 || value > DateTime.Now.Year + 1)
                    throw new ArgumentOutOfRangeException(
                        nameof(Year),
                        "Geçerli bir üretim yılı giriniz.");

                year = value;
            }
        }

        // Aracın günlük kiralama ücreti.
        // Ücretin sıfır veya negatif olması engellenir.
        public decimal DailyRate
        {
            get { return dailyRate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(
                        nameof(DailyRate),
                        "Günlük kira ücreti sıfırdan büyük olmalıdır.");

                dailyRate = value;
            }
        }

        // Araç durumunun yalnızca sınıf içerisindeki metotlarla değiştirilmesini sağlar.
        public VehicleStatus Status { get; private set; }

        // Constructor: Araç oluşturulurken zorunlu bilgileri alır.
        // protected olduğu için doğrudan Vehicle nesnesi oluşturulamaz.
        // Alt sınıflar bu constructor'ı kullanabilir.
        protected Vehicle(
            int id,
            string plate,
            string brand,
            string model,
            int year,
            decimal dailyRate)
        {
            // ID değerinin pozitif olması gerekir.
            if (id <= 0)
                throw new ArgumentException("Araç ID pozitif olmalıdır.");

            this.id = id;

            // Property'ler üzerinden atama yapılarak doğrulamalar çalıştırılır.
            Plate = plate;
            Brand = brand;
            Model = model;
            Year = year;
            DailyRate = dailyRate;

            // Yeni oluşturulan araç başlangıçta müsaittir.
            Status = VehicleStatus.Available;
        }

        // Abstract metot: Her araç türü kiralama ücretini kendi kurallarına göre hesaplar.
        // Alt sınıflarda override edilerek uygulanacaktır.
        public abstract decimal CalculateRentalPrice(int days);
        // Aracın kiralamaya uygun olup olmadığını kontrol eder.
        // IRentable arayüzünden gelen metot uygulanmıştır.
        public bool IsAvailable()
        {
            return Status == VehicleStatus.Available;
        }

        // Aracın kirada olarak işaretlenmesini sağlar.
        public void MarkAsRented()
        {
            // Zaten kirada olan bir araç tekrar kiralanamaz.
            if (Status == VehicleStatus.Rented)
                throw new InvalidOperationException("Araç zaten kirada.");

            Status = VehicleStatus.Rented;
        }

        // İade edilen aracın durumunu yeniden müsait yapar.
        public void MarkAsAvailable()
        {
            Status = VehicleStatus.Available;
        }
    }
}
