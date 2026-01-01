using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otopark otopark = new Otopark();
            bool devam = true;

            Console.WriteLine("Araba Park Sistemine Hoş Geldiniz");
            while (devam)
            {
                Console.WriteLine("\nMenü:");
                Console.WriteLine("1 - Araba Ekle");
                Console.WriteLine("2 - Araba Çıkar");
                Console.WriteLine("3 - Mevcut Arabaları Göster");
                Console.WriteLine("4 - Çıkış");
                Console.Write("\n\nSeçiminiz: ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.Write("\n\nEklenecek aracın plakasını girin: ");
                        string plakaEkle = Console.ReadLine();
                        Araba yeniAraba = new Araba(plakaEkle);
                        otopark.ArabaEkle(yeniAraba);
                        break;

                    case "2":
                        Console.Write("\n\nÇıkarılacak aracın plakasını girin: ");
                        string plakaSil = Console.ReadLine();
                        otopark.ArabaCikar(plakaSil);
                        break;

                    case "3":
                        otopark.MevcutArabalar();
                        break;

                    case "4":
                        Console.WriteLine("\n\nProgramdan çıkılıyor...");
                        devam = false;
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen 1-4 arasında bir değer girin.\n\n");
                        break;
                }
            }
        }
    }
}
