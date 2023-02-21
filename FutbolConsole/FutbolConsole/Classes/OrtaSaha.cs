using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolConsole.Classes
{
    class OrtaSaha : FootBall
    {
        public int UzunTop { get; set; }
        public int IlkDokunus { get; set; }
        public int Uretkenlik { get; set; }
        public int TopSurme { get; set; }
        public int OzelYetenek { get; set; }
        Random rnd = new Random();
        public OrtaSaha(string ad)
        {
            AdSoyad = ad;
            UzunTop = rnd.Next(60, 101);
            IlkDokunus = rnd.Next(60, 101);
            Uretkenlik = rnd.Next(60, 101);
            TopSurme = rnd.Next(60, 101);
            OzelYetenek = rnd.Next(60, 101);
        }
        public override bool PasVer()
        {
            bool pasIsabet;
            double pasVer = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + TopSurme * 0.1 + Sans * 0.1;
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
            double gol = Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + IlkDokunus * 0.1 + Kararlik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            bool golIsabet;
            if (gol > 78)
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
