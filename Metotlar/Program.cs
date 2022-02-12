using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Id = 1;
            urun1.Aciklama="Amasya Elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Id = 2;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type-safe--tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+"\n"+urun.Aciklama+ "\n"+urun.Fiyati);
                Console.WriteLine("----------------");
                
            }
            Console.WriteLine("-------------Metotlar------------");

            //instance-örnek
            //reusebility
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);




























        }
    }
}

//do not repeat yourself - DRY


