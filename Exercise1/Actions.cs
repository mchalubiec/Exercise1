using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Actions
    {
        Messages msg = new Messages();
        public string someSeries;
        public string[] someArraySeries;
        public int[] ints;
        public ConsoleKeyInfo klawisz;

        public string ReadSeries()
        {
            someSeries = Console.ReadLine();
            return someSeries;
        }
        public int[] ConvertSeries()
        {
            someArraySeries = someSeries.Trim().Split(',');
            //ints = someArraySeries.Select(int.Parse).ToArray();
            ints = Array.ConvertAll(someArraySeries, int.Parse);
            return ints;
        }
        public void Go()
        {
            msg.Command();
            ReadSeries();
        }
        public ConsoleKeyInfo Question()
        {
            msg.YesNo();
            klawisz = Console.ReadKey();
            
            return klawisz;
        }
        public void WriteSeries()
        {
            Console.Write("Podany ciąg to: ");
            for (int w = 0; w < ints.Length; w++)
            {
                Console.Write(ints[w] + " ");
            }
            Console.WriteLine();
        }
        public void Even()
        {
            Console.Write("Parzyste: ");
            for (int e = 0; e < ints.Length; e++)
            {
                if (ints[e] % 2 == 0)
                {
                    Console.Write(ints[e] + " ");
                }
            }
            Console.WriteLine();
        }
        public void Odd()
        {
            Console.Write("Nieparzyste: ");
            for (int o = 0; o < ints.Length; o++)
            {
                if (ints[o] % 2 != 0)
                {
                    Console.Write(ints[o] + " ");
                }
            }
            Console.WriteLine();
        }
        public void Sum()
        {
            int score = 0;
            for (int s = 0; s < ints.Length; s++)
            {
                score += ints[s];
            }
            if (score % 2 == 0)
            {
                Console.WriteLine($"Suma ciągu wynosi: {score} i jest parzysta.");
            }
            else { Console.WriteLine($"Suma ciągu wynosi: {score} i jest nieparzysta."); }
            Console.WriteLine();
        }
    }
}
