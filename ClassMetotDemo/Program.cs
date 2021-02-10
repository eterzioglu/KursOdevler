using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri>();

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ebru";
            musteri1.Soyad = "Terzioğlu";
            musteri1.KimlikNo = 123987456;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Esra";
            musteri2.Soyad = "Yılmaz";
            musteri2.KimlikNo = 321789654;


            MusteriManager manager = new MusteriManager();

            manager.Ekle(musteri1, musteriler);
            manager.Ekle(musteri2, musteriler);

            Console.WriteLine("------------------------------");

            manager.Listele(musteriler);

            manager.Sil(musteri1, musteriler);

        }
    }
}
