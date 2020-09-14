using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01BodaZsombor
{
    class Program
    {
        static int[] tomb = new int[1500];
        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine("A maximum: {0}", Maximumertek());
            Egyediek();
        }
        private static void Egyediek()
        {
            int x = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 5 == 0 && tomb[i] % 7 == 0)
                {
                    x++;
                    StreamWriter ir = new StreamWriter("egyediek.txt", true);
                    Console.Write(ir);
                }
                Console.WriteLine("5 és 7 oszthatóak száma: {0}", x);
            }

        }

        private static int Maximumertek(int m)
        {
            m = 1;
            for (int i = 2; i < tomb.Length; i++)
            {
                if (tomb[i]<tomb[m])
                {
                    m = i;
                }
            }
            return m;
        }

        private static void Beolvasas()
        {
            StreamReader olvas = new StreamReader("adatok.dat");
            int x = 0;
            while (!olvas.EndOfStream)
            {
                tomb[x] = int.Parse(olvas.ReadLine());
                for (int i = 0; i < tomb.Length; i++)
                {
                   tomb[x] = tomb[i] * 2;
                }
            }
        }
    }
}
