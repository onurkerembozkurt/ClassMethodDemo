using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Musteri musteri = new Musteri ();
            musteri.Name = "Kerem";
            musteri.Surname = "Bozkurt";
            musteri.Id = 123456;
            Musteri musteri2 = new Musteri();
            musteri2.Name = "Onur";
            musteri2.Surname = "Bozkurt";
            musteri.Id = 1234455;
            Musteri musteri3 = new Musteri();
            musteri3.Name = "Süleyman";
            musteri3.Surname = "Bozkurt";
            musteri3.Id = 123213213;

            Musteri[] musteriler = { musteri, musteri2, musteri3 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Silme(musteri3);
            musteriManager.Listeleme(musteriler);



        }
    }
}
/**
 * Bir bankada müşteri takibi yapmak istiyorsunuz.
Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)

MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme,
listeleme,silme gibi metotları simule ediniz.
 */