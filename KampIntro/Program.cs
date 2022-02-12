using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //Do not repeat yourself
            //değer tutucu- alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000000;
            double faizOrani = 1.45;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalma image");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artma image");
            }
            else
            {
                Console.WriteLine("Değişmedi image");
            }
            bool sistemeGirisYapmisMi= false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlarıbutonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
