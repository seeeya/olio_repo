using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator();

       
            bool kalle = true;
            while(kalle) {
                string elvis = Console.ReadLine();
                switch (elvis)
            {
                case "+": hissi.Ylos();  break;
                case "-": hissi.Alas();  break;
                default: kalle = false; break;

            }
            }
          
           
        }
    }
    class Elevator
    {
        private int MAX = 9;
        private int MIN = 0;
        private int kerros = 0;
        public void Ylos()
        {
            if (kerros == MAX)
            {
                Console.WriteLine("Et voi mennä ylemmaksi!");
            }
            else
            {
       
                kerros++;
                Console.WriteLine("Olemme nyt kerroksessa numero " + kerros);
            }
        }
        public void Alas()
        {
        if (MIN == kerros)
            {
                Console.WriteLine("Et voi mennä alemmaks ilman lapiota!");
            }
        else
            {
                kerros--;
                Console.WriteLine("Olemme nyt kerroksessa numero " + kerros);
            }
        }
    }
}
