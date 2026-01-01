using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkProjesi
{
    internal class Araba
    {
        public string Plaka { get; set; }          
        public DateTime GirisSaati { get; set; }  
        public Araba(string plaka)
        {
            Plaka = plaka;
            GirisSaati = DateTime.Now;
        }
        public void BilgileriYazdir()
        {
            Console.WriteLine($" \n\nAracın Plakası: {Plaka}, Giriş Saati: {GirisSaati}");
        }
    }
}
