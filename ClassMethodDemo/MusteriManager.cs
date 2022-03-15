using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Adlı"+musteri.Name+" "+musteri.Surname+" Sisteme Eklendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Adlı" + musteri.Name + " " + musteri.Surname + " Sistemden Silindi");
        }
        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri item in musteriler)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
