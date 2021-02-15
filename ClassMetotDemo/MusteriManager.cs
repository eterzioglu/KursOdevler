using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri, List<Musteri> musteriler)
        {
            Console.WriteLine("Tebrikler Müsteri Eklendi : " + musteri.Ad + " " + musteri.Soyad);
            musteriler.Add(musteri);
        }
        
        public void Sil(Musteri musteri, List<Musteri> musteriler)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Ad + " " + musteri.Soyad);
            musteriler.Remove(musteri);
        }

        public void Listele(List<Musteri> musteri)
        {
            foreach (var m in musteri)
            {
                Console.WriteLine("Adı : " + m.Ad);
                Console.WriteLine("Soyadı : " + m.Soyad);
                Console.WriteLine("Kimlik No : " + m.KimlikNo);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
