using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Serhat";
            musteri1.Soyad = "Yıldız";
            musteri1.Tckn = "12345678";
            musteri1.DogumYili = 1983;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Abdurrahman";
            musteri2.Soyad = "Yıldız";
            musteri2.Tckn = "12345678";
            musteri2.DogumYili = 1983;

            Musteri[] musteriList = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteriList);
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);


        }
    }
}
