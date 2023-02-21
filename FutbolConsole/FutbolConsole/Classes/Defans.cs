using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolConsole.Classes
{
    class Defans : FootBall
    {
        public int PozisyonAlma { get; set; }
        public int Kafa { get; set; }
        public int Sicrama { get; set; }
        Random rnd = new Random();
        public Defans(string ad)
        {
            AdSoyad = ad;
            PozisyonAlma = rnd.Next(50, 91);
            Kafa = rnd.Next(50, 91);
            Sicrama = rnd.Next(50, 91);
        }

        public override bool PasVer()
        {
            double pasVer = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;
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
            double gol = Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.1;
            bool golIsabet;
            if (gol > 82)
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
