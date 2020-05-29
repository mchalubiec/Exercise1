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
        #region fields
        public string userString;
        public string[] arrayString;
        public int[] arrayInt;
        public ConsoleKeyInfo endKey;
        public bool validate;
        public int result;
        public bool isParsable;
        #endregion
        #region methods
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
                if (!String.IsNullOrEmpty(cell))
                {
                    validate = true;
                }
                else { validate = false; return; }
            }
        }
        public void ConvertArray()
        {
            List<int> list = new List<int>();
            foreach (var value in arrayString)
            {
                isParsable = int.TryParse(value, out result);
                if (!isParsable)
                {
                    return;
                }
                else { list.Add(result); }
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
        /// <summary>
        /// Write string
        /// </summary>
        public void WriteSeries()
        {
            Console.WriteLine();
            Console.Write("a. Podany ciąg to: ");
            for (int w = 0; w < arrayInt.Length; w++)
            {
                Console.Write(arrayInt[w] + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Check which numbers in string are even and write them.
        /// </summary>
        public void WriteEven()
        {
            Console.Write("b. Parzyste: ");
            for (int e = 0; e < arrayInt.Length; e++)
            {
                if (arrayInt[e] % 2 == 0)
                {
                    Console.Write(arrayInt[e] + " ");
                }
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Check which numbers in string are odd and write them.
        /// </summary>
        public void WriteOdd()
        {
            Console.Write("c. Nieparzyste: ");
            for (int o = 0; o < arrayInt.Length; o++)
            {
                if (arrayInt[o] % 2 != 0)
                {
                    Console.Write(arrayInt[o] + " ");
                }
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Write sum all elements of string, check even/odd this sum and write it.
        /// </summary>
        public void WriteSum()
        {
            int score = 0;
            for (int s = 0; s < arrayInt.Length; s++)
            {
                score += arrayInt[s];
            }
            if (score % 2 == 0)
            {
                Console.WriteLine($"d. Suma ciągu wynosi: {score} i jest liczbą parzystą.");
            }
            else { Console.WriteLine($"Suma ciągu wynosi: {score} i jest liczbą nieparzystą."); }
            Console.WriteLine();
        }
        #endregion
    }
}
