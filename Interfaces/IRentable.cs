
using System;

namespace WinFormsApp1.Interfaces
{
    // Interface: Kiralanabilir nesnelerin uygulaması gereken metotları tanımlar.
    // Bu arayüz, kiralama davranışını ortak bir sözleşme haline getirir.
    public interface IRentable
    {
        // Belirtilen gün sayısına göre kiralama ücretini hesaplar.
        decimal CalculateRentalPrice(int days);

        // Nesnenin kiralama durumunu kontrol eder.
        bool IsAvailable();
    }
}
