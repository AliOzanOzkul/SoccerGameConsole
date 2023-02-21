using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolConsole.Classes
{
    class FootBall
    {
        protected string AdSoyad { get; set; }
        protected int FormaNo { get; set; }
        protected int Hiz { get; set; }
        protected int Dayaniklilik { get; set; }
        protected int Pas { get; set; }
        protected int Sut { get; set; }
        protected int Yetenek { get; set; }
        protected int Kararlik { get; set; }
        protected int DogalForm { get; set; }
        protected int Sans { get; set; }
        Random rnd = new Random();
        static int i = 1;
        public FootBall()
        {
            FormaNo = i;
            i++;
            Hiz = rnd.Next(50, 101);
            Dayaniklilik = rnd.Next(50, 101);
            Pas = rnd.Next(50, 101);
            Sut = rnd.Next(50, 101);
            Yetenek = rnd.Next(50, 101);
            Kararlik = rnd.Next(50, 101);
            DogalForm = rnd.Next(50, 101);
            Sans = rnd.Next(50, 101);
        }

        public virtual bool PasVer()
        {
            double pasVer = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2;
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
        public virtual bool GolVurus()
        {
            double gol = Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2;
            bool golIsabet;
            if (gol > 80)
            {
                golIsabet = true;
            }
            else
            {
                golIsabet = false;
            }

            return golIsabet;
            
        }
        public virtual void FormaNoGoster()
        {
            Console.WriteLine(this.FormaNo + " Forma Numaralı Oyuncu " + this.AdSoyad);
        }

    }
}
