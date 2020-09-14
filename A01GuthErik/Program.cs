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

        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine("A maximum: {0}", Maximumertek());

            Console.ReadKey();
        }
    }
}
