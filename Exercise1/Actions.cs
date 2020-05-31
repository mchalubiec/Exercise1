using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Actions
    {
        #region Objects
        Messages msg = new Messages();
        #endregion
        #region Private Fields
        private string userString;
        private string[] arrayString;
        private int[] arrayInt;
        private ConsoleKeyInfo endKey;
        #endregion
        #region Public Fields
        public bool validate;
        #endregion
        #region Methods
        /// <summary>
        /// Displays instruction, get string from user and validate is it empty.
        /// </summary>
        public void GetStringIfNoEmpty()
        {
            do
            {
                msg.DisplayText("Podaj ciąg liczbowy (dowolnej długości), oddzielając cyfry przecinkiem: ");
                userString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userString))
                {
                    msg.DisplayErrorText("Nie podałeś żadnego ciągu.");
                }
            } while (string.IsNullOrWhiteSpace(userString));
        }
        /// <summary>
        /// Trys to convert user string to array int and validates is it possible.
        /// </summary>
        public void ConvertStringAndValidate()
        {
            arrayString = userString.Split(',');

            List<int> list = new List<int>();
            foreach (string value in arrayString)
            {
                if (!String.IsNullOrEmpty(value))
                {
                    int result;
                    if (int.TryParse(value, out result))
                    {
                        list.Add(result);
                    }
                    else { validate = false; msg.DisplayErrorText("Podany ciąg zawiera litery lub znaki specjalne."); return; }
                }
                else { validate = false; msg.DisplayErrorText("W podanym ciągu brakuje liczb(y)."); return; }
            }
            validate = true;
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
