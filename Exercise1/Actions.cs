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
        public string userString;
        public string[] arrayString;
        public int[] arrayInt;
        public ConsoleKeyInfo endKey;
        public bool validate;

        public void ReadString()
        {
            userString = Console.ReadLine();
        }
        public void StringToArray()
        {
            arrayString = userString.Split(',');
        }
        public bool Validate()
        {
            foreach (string cell in arrayString)
            {
                if (cell.All(char.IsDigit) && String.IsNullOrEmpty(cell))
                {
                    validate = true;
                }
                else { validate = false; } 
            }
            return validate;
        }
        public void ConvertArray()
        {
            arrayInt = Array.ConvertAll(arrayString, int.Parse);
            //arrayInt = someArraySeries.Select(int.Parse).ToArray();
        }
        public void Go()
        {
            msg.Command();
            ReadString();
        }
        public void Question()
        {
            msg.YesNo();
            endKey = Console.ReadKey();            
        }
        public void WriteSeries()
        {
            Console.Write("Podany ciąg to: ");
            for (int w = 0; w < arrayInt.Length; w++)
            {
                Console.Write(arrayInt[w] + " ");
            }
            Console.WriteLine();
        }
        public void Even()
        {
            Console.Write("Parzyste: ");
            for (int e = 0; e < arrayInt.Length; e++)
            {
                if (arrayInt[e] % 2 == 0)
                {
                    Console.Write(arrayInt[e] + " ");
                }
            }
            Console.WriteLine();
        }
        public void Odd()
        {
            Console.Write("Nieparzyste: ");
            for (int o = 0; o < arrayInt.Length; o++)
            {
                if (arrayInt[o] % 2 != 0)
                {
                    Console.Write(arrayInt[o] + " ");
                }
            }
            Console.WriteLine();
        }
        public void Sum()
        {
            int score = 0;
            for (int s = 0; s < arrayInt.Length; s++)
            {
                score += arrayInt[s];
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
