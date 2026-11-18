
using System;
using System.Linq;

namespace WinFormsApp1.Models
{
    // Customer sınıfı, sistemde kayıtlı müşterilerin bilgilerini tutar.
    public class Customer
    {
        // Müşteri bilgileri dışarıdan doğrudan erişime kapatılmıştır.
        private int id;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string phone = string.Empty;
        private string licenseNumber = string.Empty;

        // Müşterinin benzersiz kimlik numarası.
        public int Id
        {
            get { return id; }
        }

        // Müşterinin adı.
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Müşteri adı boş bırakılamaz.");

                firstName = value.Trim();
            }
        }

        // Müşterinin soyadı.
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Müşteri soyadı boş bırakılamaz.");

                lastName = value.Trim();
            }
        }

        // Telefon numarası: Yalnızca rakamlardan oluşmalıdır.
        // 10 veya 11 haneli telefon numaraları kabul edilir.
        public string Phone
        {
            get { return phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Telefon numarası boş bırakılamaz.");

                // Boşluk ve yaygın telefon ayraçları temizlenir.
                string cleanedPhone = value.Trim()
                    .Replace(" ", "")
                    .Replace("-", "")
                    .Replace("(", "")
                    .Replace(")", "");

                // Telefon numarasının yalnızca rakamlardan oluştuğu kontrol edilir.
                if (!cleanedPhone.All(char.IsDigit))
                    throw new ArgumentException(
                        "Telefon numarası yalnızca rakamlardan oluşmalıdır.");

                // Türkiye telefon numaraları için temel uzunluk kontrolü.
                if (cleanedPhone.Length != 10 && cleanedPhone.Length != 11)
                    throw new ArgumentException(
                        "Telefon numarası 10 veya 11 haneli olmalıdır.");

                phone = cleanedPhone;
            }
        }

        // Müşterinin ehliyet numarası.
        public string LicenseNumber
        {
            get { return licenseNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ehliyet numarası boş bırakılamaz.");

                licenseNumber = value.Trim().ToUpperInvariant();
            }
        }

        // Constructor: Yeni müşteri oluşturulurken zorunlu bilgileri alır.
        public Customer(
            int id,
            string firstName,
            string lastName,
            string phone,
            string licenseNumber)
        {
            // Müşteri ID'sinin pozitif olması gerekir.
            if (id <= 0)
                throw new ArgumentException("Müşteri ID pozitif olmalıdır.");

            this.id = id;

            // Property'ler üzerinden doğrulama yapılır.
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            LicenseNumber = licenseNumber;
        }

        // Müşterinin adını ve soyadını birlikte döndürür.
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // Müşteri bilgilerini okunabilir biçimde döndürür.
        public override string ToString()
        {
            return GetFullName() + " - " + Phone;
        }
    }
}
