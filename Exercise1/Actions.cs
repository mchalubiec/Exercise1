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
        public int result;

        public void ReadString()
        {
            userString = Console.ReadLine();
        }
        public void StringToArray()
        {
            arrayString = userString.Split(',');
        }
        public void Validate()
        {
            foreach (string cell in arrayString)
            {
                if (!String.IsNullOrEmpty(cell) && cell.All(char.IsDigit))
                {                    
                    validate = true;
                }
                else { validate = false; }
            }
        }
        public void ConvertArray()
        {
            List<int> list = new List<int>();
            foreach (var value in arrayString)
            {
                bool isParsable = Int32.TryParse(value, out result);
                if (!isParsable)
                {
                    msg.BadSeries();
                }
                list.Add(result);
            }
            arrayInt = list.ToArray();
        }
        public void Go()
        {
            msg.Command();
            ReadString();
        }
        public void Question()
        {
            msg.YesNo();
            endKey = Console.ReadKey(true);            
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
        public void WriteEven()
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
        public void WriteOdd()
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
        public void WriteSum()
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
