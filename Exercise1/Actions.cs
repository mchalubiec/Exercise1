using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Actions
    {
        Messages msg = new Messages();

        #region Fields
        public string userString;
        public string[] arrayString;
        public int[] arrayInt;
        public bool validate;
        public bool isParsable;
        public int result;
        public ConsoleKeyInfo endKey;
        public bool exit;
        #endregion
        #region Methods
        /// <summary>
        /// Displays instruction and get string from user.
        /// </summary>
        public void Start()
        {
            msg.Instruction();
            ReadString();
        }
        /// <summary>
        /// Read any string from user and validate is it empty string.
        /// </summary>
        public void ReadString()
        {
            userString = Console.ReadLine();
            if (!String.IsNullOrEmpty(userString))
            {
                validate = true;
            }
            else{ msg.EmptyString(); return; }
        }
        /// <summary>
        /// Converts user string to array string, next converts to array int with validate.
        /// </summary>
        public void ConvertString()
        {
            arrayString = userString.Split(',');

            List<int> list = new List<int>();
            foreach (string value in arrayString)
            {
                if (!String.IsNullOrEmpty(value))
                {
                    validate = true;
                    isParsable = int.TryParse(value, out result);
                    if (isParsable)
                    {
                        list.Add(result);
                    }
                    else { validate = false; msg.WrongString();  return; }
                }
                else { validate = false; msg.EmptyField(); return; }
            }
            arrayInt = list.ToArray();
        }
        /// <summary>
        /// Display tasks.
        /// </summary>
        public void Display()
        {
            WriteString();
            WriteEven();
            WriteOdd();
            WriteSum();
        }
        /// <summary>
        /// Write all elements of string given by user.
        /// </summary>
        public void WriteString()
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
        /// Check which elements of string are even and write them.
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
        /// Check which elements of string are odd and write them.
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
            else { Console.WriteLine($"d. Suma ciągu wynosi: {score} i jest liczbą nieparzystą."); }
            Console.WriteLine();
        }

        public void End()
        {
            msg.YesNo();
            endKey = Console.ReadKey(true);
            if (endKey.Key == ConsoleKey.N)
            {
                Environment.Exit(0);
            }
            if (endKey.Key == ConsoleKey.Y)
            {
                exit = true; return;
            }
            else { msg.WrongKey(); }
        }
        #endregion
    }
}
