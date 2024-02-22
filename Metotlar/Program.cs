namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //int Fiyat = 15;
            //string Aciklama = "Malatya Elması";

            //string[] meyveler = new string[] { };


            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Malatya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type-safe -- tip güvenli
            //foreach döngü yapar.
            //var arka planda Urun diye çalışır.

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

               

            }

            Console.WriteLine("---------METOTLAR------------");
            
            //instance = klas örneği
            //encapsulation


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 15);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 19);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 99);

        }
    }
}

/// Metot: tekrar tekrar kullanılabilirliği sağlar.

/// dont repeat yourself: DRY - Clean Code: Temiz Kod - Best Practice:en iyi Uygulama teknikleri