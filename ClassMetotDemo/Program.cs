using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Bora Kaya";
            musteri1.Tel = "05391590987";
            musteri1.Adres = "Bayrampasa Dunya Sokak";
            musteri1.ID = 49842662651210;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Betul Kaya";
            musteri2.Tel = "05356147748";
            musteri2.Adres = "Besiktas Barbaros Bulvarı";
            musteri2.ID = 08465116595;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            Console.WriteLine("--------------------");

            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriSil(musteri2);

        }

    }
}
