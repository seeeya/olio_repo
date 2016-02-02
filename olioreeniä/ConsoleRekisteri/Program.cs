using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ConsoleRekisteri
{
    class Program
    {
        static Random rnd = new Random();
        static string Uusnimi(int lenght)
        {
            string uusnimi = null;
           
            for(int i = 0; i < lenght;i++)
            {
                uusnimi += (char)rnd.Next('A', 'Z');
            }
            return uusnimi;
        }
        static void Main(string[] args)
        {
            Stopwatch kekke = new Stopwatch();
            Random rnd = new Random();
            List<Person> persons = new List<Person>();
            for (int i = 0;i < 200;i++)
            { 
            int randomi = rnd.Next(100000, 111111);
                int randomi2 = rnd.Next(1000, 1111);
                string sepi = randomi + "-" + randomi2;
            persons.Add(new Person(sepi, Uusnimi(rnd.Next(3,5)), Uusnimi(rnd.Next(9, 15)), rnd.Next(1, 80), rnd.Next(20, 220), rnd.Next(100, 220)));
        }

       /*
            foreach (Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }
            */
            Console.WriteLine("----------------------------------------------------");
            persons.Sort((x, y) => x.Age.CompareTo(y.Age));
            foreach (Person somebody2 in persons)
            {
                Console.Write(somebody2.ToString());
            }
            kekke.Start();
            int luku = 0;
            bool keke = true;
            while(keke) { 
            int randomi3 = rnd.Next(100000, 111111);
            int randomi4 = rnd.Next(1000, 1111);
            string SSN = randomi3 + "-" + randomi4;
               
            Person found = persons.Find(x => x.SSN == SSN);
           
            if (found != null)
            {
                    Console.WriteLine("Person with SSN " + SSN + " FOUND!");
                    kekke.Stop();
                    keke = false;

            }
            else
            {
                  luku++;
                //Console.WriteLine(SSN);
                //Console.WriteLine("Person not found!");
            }
            }
            Console.WriteLine("Kyselyja tehty " + luku + " Ajassa " + kekke.ElapsedMilliseconds + "ms");
            Console.ReadLine();
        }

    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string SSN { get; set; }


        public Person(string SsN, string firstName, string lastName, int age, int weight, int height)
        {
            this.SSN = SsN;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }

        public override string ToString()
        {
            return "SSN "+SSN+" | FirstName: " + FirstName + " Lastname: " + LastName + " " + Age + " Years old " + Weight + "kg " + Height + "cm \n";
            
        }
    }
}
