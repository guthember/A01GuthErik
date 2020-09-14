using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01GuthErik
{
    class Program
    {
        static int[] tomb = new int[1000];

        static void Beolvasas()
        {
            StreamReader file = new StreamReader("adatok.dat");

            
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = int.Parse(file.ReadLine()) * 2;
            }

            file.Close();
        }

        static int Maximumertek()
        {
            int maxHely = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[maxHely] < tomb[i])
                {
                    maxHely = i;
                }
            }
            return tomb[maxHely];
        }

        static int Egyediek()
        {
            StreamWriter file = new StreamWriter("egyediek.txt");
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if ((tomb[i] % 5 == 0) && (tomb[i] % 7 == 0))
                {
                    db++;
                    file.WriteLine(tomb[i].ToString());
                }
            }
            file.Close();

            return db;
        }

        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine("A maximum: {0}", Maximumertek());
            Console.WriteLine("5 és 7 oszthatóak száma: {0}", Egyediek());

            Console.ReadKey();
        }
    }
}
