using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolConsole.Classes
{
    class Forvet : FootBall
    {
        public int Bitiricilik { get; set; }
        public int IlkDokunus { get; set; }
        public int Kafa { get; set; }
        public int OzelYetenek { get; set; }
        public int SogukKanlilik { get; set; }
        
        public void Yaz()
        {
            Console.WriteLine($"Ad Soyad{AdSoyad} Forma No {FormaNo} Dayanıklılık {Dayaniklilik}");

        }
        Random rnd = new Random();
        public Forvet(string ad)
        {
            AdSoyad = ad;
            Bitiricilik = rnd.Next(70, 101);
            IlkDokunus = rnd.Next(70, 101);
            Kafa = rnd.Next(70, 101);
            OzelYetenek = rnd.Next(70, 101);
            SogukKanlilik = rnd.Next(70, 101);
           
        }
        public override bool PasVer()
        {
            double pasVer = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            bool pasIsabet;
            if (pasVer > 60)
            {
                pasIsabet = true;
            }
            else
            {
                pasIsabet = false;
            }

            return pasIsabet;
        }
        public override bool GolVurus()
        {
            double gol = Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + SogukKanlilik * 0.1 + Kararlik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            bool golIsabet;

            if (gol > 70)
            {
                golIsabet = true;
            }
            else
            {
                golIsabet = false;
            }

            return golIsabet;


        }
        public override void FormaNoGoster()
        {
            Console.WriteLine(this.FormaNo + " Forma Numaralı Oyuncu " + this.AdSoyad);
        }

    }
}
