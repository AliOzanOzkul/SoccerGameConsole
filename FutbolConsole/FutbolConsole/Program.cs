using FutbolConsole.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<FootBall> footBall = new List<FootBall>();
            
            
            footBall.Add(new Defans("Oyuncu 1"));
            footBall.Add(new Defans("Oyuncu 2"));
            footBall.Add(new Defans("Oyuncu 3"));
            footBall.Add(new Defans("Oyuncu 4"));
            footBall.Add(new OrtaSaha("Oyuncu 5"));
            footBall.Add(new OrtaSaha("Oyuncu 6"));
            footBall.Add(new OrtaSaha("Oyuncu 7"));
            footBall.Add(new OrtaSaha("Oyuncu 8"));
            footBall.Add(new Forvet("Oyuncu 9"));
            footBall.Add(new Forvet("Oyuncu 10"));


            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < 3; i++)
            {
                while (num1 == num2)
                {
                num1 = rnd.Next(0, 10);

                }
                num2 = num1;

                if (footBall[num1].PasVer())
                {
                    
                    Console.WriteLine($"Pas başarılı");
                    if (i == 2 && footBall[num1].GolVurus())
                    {

                        Console.WriteLine("Gooooool");
                        footBall[num1].FormaNoGoster();
                    }
                    else if(i == 2 && !footBall[num1].GolVurus())
                    {
                        Console.WriteLine("Top Az Farkla Dışarı Çıktı ");
                        footBall[num1].FormaNoGoster();
                    }
                }
                else
                {
                    Console.WriteLine(num1);
                    Console.WriteLine("Pas Başarısız");
                }
            }
            
                
                
            

            Console.ReadLine();
        }
    }
}
