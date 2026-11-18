
using System;

namespace WinFormsApp1.Models
{
    // Kiralama işleminin durumunu belirleyen enum.
    public enum RentalStatus
    {
        Active,     // Kiralama devam ediyor.
        Completed   // Araç iade edilmiş.
    }

    // Rental sınıfı, araç kiralama işlemlerinin bilgilerini tutar.
    public class Rental
    {
        // Kiralama bilgilerini korumak için private alanlar kullanılır.
        private int id;
        private Customer customer;
        private Vehicle vehicle;
        private DateTime startDate;
        private DateTime endDate;
        private int totalDays;
        private decimal totalPrice;

        // Kiralama işleminin benzersiz numarası.
        public int Id
        {
            get { return id; }
        }

        // Kiralamayı gerçekleştiren müşteri.
        public Customer Customer
        {
            get { return customer; }
        }

        // Kiralanan araç.
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Kiralama başlangıç tarihi.
        public DateTime StartDate
        {
            get { return startDate; }
        }

        // Planlanan iade tarihi.
        public DateTime EndDate
        {
            get { return endDate; }
        }

        // Kiralama süresi gün olarak saklanır.
        public int TotalDays
        {
            get { return totalDays; }
        }

        // Kiralama için hesaplanan toplam ücret.
        public decimal TotalPrice
        {
            get { return totalPrice; }
        }

        // Kiralama işleminin aktif veya tamamlanmış olduğunu belirtir.
        public RentalStatus Status { get; private set; }

        // Constructor: Yeni bir kiralama işlemi oluşturur.
        public Rental(
            int id,
            Customer customer,
            Vehicle vehicle,
            DateTime startDate,
            DateTime endDate)
        {
            // Kiralama ID'si pozitif olmalıdır.
            if (id <= 0)
                throw new ArgumentException("Kiralama ID pozitif olmalıdır.");

            // Müşteri ve araç bilgileri boş bırakılamaz.
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle));

            // Bitiş tarihi başlangıç tarihinden önce olamaz.
            if (endDate.Date < startDate.Date)
                throw new ArgumentException(
                    "İade tarihi başlangıç tarihinden önce olamaz.");

            // Kiralama işlemi yalnızca müsait araçlarla yapılabilir.
            if (vehicle.Status != VehicleStatus.Available)
                throw new InvalidOperationException(
                    "Seçilen araç kiralamaya uygun değildir.");

            this.id = id;
            this.customer = customer;
            this.vehicle = vehicle;
            this.startDate = startDate.Date;
            this.endDate = endDate.Date;

            // Kiralama süresi hesaplanır.
            // Başlangıç ve bitiş günleri arasındaki fark kullanılır.
            totalDays = (this.endDate - this.startDate).Days;

            // Aynı gün içerisinde kiralama yapılırsa en az 1 gün ücret alınır.
            if (totalDays == 0)
                totalDays = 1;

            // Ücret, aracın kendi hesaplama metodu üzerinden belirlenir.
            totalPrice = vehicle.CalculateRentalPrice(totalDays);

            // Araç kirada olarak işaretlenir.
            vehicle.MarkAsRented();

            // Yeni kiralama işlemi aktif olarak başlar.
            Status = RentalStatus.Active;
        }

        // Araç iade edildiğinde kiralama işlemini tamamlar.
        public void CompleteRental()
        {
            // Tamamlanmış bir kiralama tekrar tamamlanamaz.
            if (Status == RentalStatus.Completed)
                throw new InvalidOperationException(
                    "Bu kiralama işlemi zaten tamamlanmış.");

            // Kiralama durumu tamamlandı olarak değiştirilir.
            Status = RentalStatus.Completed;

            // İade edilen araç yeniden müsait duruma getirilir.
            vehicle.MarkAsAvailable();
        }
    }
}
