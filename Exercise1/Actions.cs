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
        private ConsoleKeyInfo endKey;
        #endregion
        #region Methods
        /// <summary>
        /// Displays instruction, get string from user and validate is it empty.
        /// </summary>
        public void GetStringAndValidate()
        {
            do
            {
                msg.DisplayText("Podaj ciąg liczbowy (dowolnej długości), oddzielając cyfry przecinkiem: ");
                userString = Console.ReadLine();
                if (String.IsNullOrEmpty(userString))
                {
                    msg.DisplayErrorText("Nie podałeś żadnego ciągu.");
                }
            } while (String.IsNullOrEmpty(userString));
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
                    int result;
                    validate = true;
                    isParsable = int.TryParse(value, out result);
                    if (isParsable)
                    {
                        list.Add(result);
                    }
                    else { validate = false; msg.DisplayErrorText("Podany ciąg zawiera litery lub znaki specjalne."); return; }
                }
                else { validate = false; msg.DisplayErrorText("W podanym ciągu brakuje liczb(y)."); return; }
            }
            arrayInt = list.ToArray();
        }
        /// <summary>
        /// Displays tasks.
        /// </summary>
        public void DisplayTasks()
        {
            WriteString();
            WriteEven();
            WriteOdd();
            WriteSum();
        }
        /// <summary>
        /// Writes all elements of string given by user.
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
        /// Checks which elements of string are even and write them.
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
        /// Checks which elements of string are odd and write them.
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
        /// Writes sum all elements of string, check even/odd this sum and write it.
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
        /// <summary>
        /// Asks user whether to end program or start again.
        /// </summary>
        public void EndOrAgain()
        {
            do
            {
                msg.DisplayText("Czy chcesz spróbować ponownie? (Y/N)");
                endKey = Console.ReadKey(true);
                if (endKey.Key != ConsoleKey.N && endKey.Key != ConsoleKey.Y)
                {
                    msg.DisplayErrorText("Nie rozpoznano klawisza.");                    
                }
                if (endKey.Key == ConsoleKey.N)
                {
                    Environment.Exit(0);
                }
            } while (endKey.Key != ConsoleKey.Y);
        }
        #endregion
    }
}
