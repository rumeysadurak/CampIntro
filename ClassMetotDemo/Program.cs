using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Musteri> musteriler = new List<Musteri>();
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Sol";
            musteri1.Id = 1;
            musteri1.Mail = "alisol@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Sevil";
            musteri2.Soyad = "Pırıl";
            musteri2.Id = 2;
            musteri2.Mail = "sevilpiril@hotmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Petek";
            musteri3.Soyad = "Yıldız";
            musteri3.Id = 3;
            musteri3.Mail = "petekyildiz@outlook.com";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri3);

        }
    }
}
