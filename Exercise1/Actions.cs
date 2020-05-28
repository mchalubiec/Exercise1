using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Actions
    {
        public string someSeries;

        public string ReadSeries()
        {
            return someSeries = Console.ReadLine();
        }
        public int[] ConvertSeries()
        {
            string[] someArraySeries = new string[] { someSeries };
            someArraySeries = someSeries.Replace(" ", "").Split(',');
            int[] ints = someArraySeries.Select(int.Parse).ToArray();
            //int[] ints = Array.ConvertAll(someArraySeries, int.Parse);
            return ints;
        }

        public void Even()
        {
            for (int e = 0; e < ints.Length; e++)
            {
                if (ints[e] % 2 == 0)
                {
                    Console.WriteLine(ints[e] + "parzysta");
                }
            }

        }
        public void Odd()
        {
            for (int o = 0; o < ints.Length; o++)
            {
                if (ints[o] % 2 == 1)
                {
                    Console.WriteLine(ints[o] + "nieparzysta");
                }
            }
        }
        public void Sum()
        {
            int score = 0;
            for (int s = 0; s < ints.Length; s++)
            {
                score += ints[s];
            }
            Console.WriteLine(score + "suma");
        }
    }
}
