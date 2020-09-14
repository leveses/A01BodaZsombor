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
