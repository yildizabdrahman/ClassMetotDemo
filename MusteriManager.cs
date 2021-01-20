using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriListele(Musteri[] musteriler)
        {

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Tckn);
                Console.WriteLine(musteri.DogumYili);
                Console.WriteLine("\n");
            }
          

        }

        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" Eklendi");

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Silindi");
        }
    }
}
