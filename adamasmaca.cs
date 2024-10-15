using System;

class Program
{
    static void Main()
    {
        // Gizli kelimeyi ben seçiyorum: "ışıltı"
        string gizliKelime = "ışıltı";

        // Kelimenin harflerini '_' ile gizliyorum
        char[] tahminEdilen = { '_', '_', '_', '_', '_', '_' };

        // Oyuncunun 10 canı var
        int can = 10;

        // Oyun döngüsü, oyuncunun canı bitene kadar devam edecek
        while (can > 0)
        {
            // Şu anki kelimenin durumu
            Console.WriteLine("Kelime: " + new string(tahminEdilen));
            Console.WriteLine("Kalan can: " + can);

            // Kullanıcıdan harf tahmini alıyorum
            Console.Write("Bir harf girin: ");
            char tahmin = Convert.ToChar(Console.ReadLine());

            // Tahmin edilen harf doğru mu kontrol ediyorum
            bool dogruTahmin = false;
            for (int i = 0; i < gizliKelime.Length; i++)
            {
                if (gizliKelime[i] == tahmin)
                {
                    tahminEdilen[i] = tahmin;  // Doğru tahmin edilirse yerine koyuyorum
                    dogruTahmin = true;
                }
            }

            // Eğer yanlış tahmin edilirse can azalıyor
            if (!dogruTahmin)
            {
                can--;
            }

            // Eğer kelimenin tüm harfleri doğru tahmin edildiyse oyunu kazandın
            if (new string(tahminEdilen) == gizliKelime)
            {
                Console.WriteLine("Tebrikler! Kelimeyi buldunuz: " + gizliKelime);
                break;
            }
        }

        // Can bittiğinde oyun sona erer
        if (can == 0)
        {
            Console.WriteLine("Kaybettiniz! Kelime: " + gizliKelime);
        }
        // Kullanıcıdan bir tuşa basmasını bekliyorum, böylece konsol kapanmaz
        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();  // Kullanıcı bir tuşa basana kadar bekle
    }
}
