using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            
            Console.WriteLine("Tebrikler! " + musteri.Ad + " " + musteri.Soyad + " İsimli müşteri başarıyla eklendi!");

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! " + musteri.Ad + " " + musteri.Soyad + " İsimli müşteri başarıyla silindi!");

        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelenen müşteri:\n"+musteri.Ad + " " +musteri.Soyad +"\n"+musteri.Id+"\n"+musteri.Mail);

        }



    }
}
