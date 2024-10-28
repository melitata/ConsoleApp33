using System;
namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            //out parametreler
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot aşırı yükleme - overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Ahmet", "Mehmet");

            //Metot imzası
            //MetotAdı + Parametre Sayısı + Parametre
            





        }

    }


    class Metotlar
    {

        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }




    }   }
