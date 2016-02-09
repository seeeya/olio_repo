using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            Noppa noppa = new Noppa();
            Console.WriteLine("Monta kertaa haluat heittaa noppaa? >");
            int luku = int.Parse(Console.ReadLine());
            noppa.NoppaRun(luku);
        }
    }

    public class Noppa
    {
        Random rand = new Random();
        private double yksi = 0;
        private double kaksi = 0;
        private double kolme = 0;
        private double nelja = 0;
        private double viisi = 0;
        private double kuusi = 0;


        public void NoppaRandom()
        {
            int numerot = rand.Next(1, 7);
           // Console.WriteLine("Sait nopasta numeron " + numerot);
            switch(numerot)
            {
                case 1: yksi++;  break;
                case 2: kaksi++; break;
                case 3: kolme++;  break;
                case 4: nelja++;  break;
                case 5: viisi++;  break;
                case 6: kuusi++;  break;
                default: break;


            }

        }
        public void NoppaRun(int runTimes)
        {
            for (int i = 0; i < runTimes; i++)
            {
                NoppaRandom();
            }
            
            Console.WriteLine();
            double kerrat = yksi + kaksi + kolme + nelja + viisi + kuusi;
            double keksiarvo = 0;
            keksiarvo = (double)((yksi+2*kaksi+ 3*kolme + 4*nelja + 5*viisi + 6*kuusi)/kerrat);
            Console.WriteLine("Heitit noppaa "+kerrat+" kertaa ja sait numeroita seuraavasti: ");
            Console.WriteLine("Heittojen keskiarvo on " +keksiarvo );
            Console.WriteLine("1: " + yksi + " kertaa");
            Console.WriteLine("2: " + kaksi + " kertaa");
            Console.WriteLine("3: " + kolme + " kertaa");
            Console.WriteLine("4: " + nelja + " kertaa");
            Console.WriteLine("5: " + viisi + " kertaa");
            Console.WriteLine("6: " + kuusi + " kertaa");

        }
        public double LaskePros(int luku, int kerrat)
        {
            return (luku / kerrat) * 100;
        }
    }

}
