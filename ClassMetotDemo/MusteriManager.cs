using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi:" + musteri.Ad);
        }
        
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Musteri Adi:"+musteri.Ad+ " " + "Tel:" + musteri.Tel + " "+ "Adres:" + musteri.Adres + " " + "ID:" + musteri.ID);        
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi:" + musteri.Ad);
        }
    }
}
