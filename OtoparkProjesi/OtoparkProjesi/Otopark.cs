using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkProjesi
{
    internal class Otopark
    {
        private Araba[] arabalar = new Araba[20];
        private int mevcutArabaSayisi = 0;
        private const int saatlikUcret = 5;
        public void ArabaEkle(Araba yeniAraba)
        {
            if (mevcutArabaSayisi >= arabalar.Length)
            {
                Console.WriteLine("Otopark dolu, araç eklenemiyor!\n\n");
                return;
            }
            for (int i = 0; i < mevcutArabaSayisi; i++)
            {
                if (arabalar[i].Plaka == yeniAraba.Plaka)
                {
                    Console.WriteLine("Bu plaka otoparkta mevcut!\n\n");
                    return;
                }
            }
            arabalar[mevcutArabaSayisi] = yeniAraba;
            mevcutArabaSayisi++;
            Console.WriteLine("Araç başarıyla eklendi!\n\n");
        }
        public void ArabaCikar(string plaka)
        {
            bool bulundu = false;

            for (int i = 0; i < mevcutArabaSayisi; i++)
            {
                if (arabalar[i].Plaka == plaka)
                {
                    bulundu = true;
                    decimal ucret = SaatUcret(arabalar[i]);
                    Console.WriteLine($"\n\nAraç çıkarılıyor... \n\nÖdenecek ücret: {ucret} TL dir.");
                    for (int j = i; j < mevcutArabaSayisi - 1; j++)
                    {
                        arabalar[j] = arabalar[j + 1];
                    }
                    arabalar[mevcutArabaSayisi - 1] = null;
                    mevcutArabaSayisi--;
                    break;
                }
            }
            if (!bulundu)
                Console.WriteLine("Bu plaka bulunamadı!\n\n");
        }
        public void MevcutArabalar()
        {
            if (mevcutArabaSayisi == 0)
            {
                Console.WriteLine("Otoparkta araç yok!\n\n");
                return;
            }
            Console.WriteLine("\n\nParktaki Araçlar");
            for (int i = 0; i < mevcutArabaSayisi; i++)
            {
                arabalar[i].BilgileriYazdir();
            }
        }
        public decimal SaatUcret(Araba araba)
        {
            TimeSpan fark = DateTime.Now - araba.GirisSaati;
            double toplamSaat = fark.TotalHours;
            if (toplamSaat < 1)
                toplamSaat = 1;
            return (decimal)(toplamSaat * saatlikUcret);
        }
    }
}
