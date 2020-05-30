using System;

namespace Exercise1
{
    class Messages
    {
        #region methods
        public void Instruction()
        {
            Console.ResetColor();
            Console.WriteLine("Podaj ciąg liczbowy (dowolnej długości), oddzielając cyfry przecinkiem: ");
        }
        public void EmptyString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie podałeś żadnego ciągu.");
        }
        public void WrongString()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podany ciąg zawiera litery lub znaki specjalne.");
            Console.WriteLine();
        }
        public void EmptyField()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("W podanym ciągu brakuje liczb(y).");
            Console.WriteLine();
        }
        public void WrongKey()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie rozpoznano klawisza.");
            Console.WriteLine();
        }
        public void YesNo()
        {
            Console.ResetColor();
            Console.WriteLine("Czy chcesz spróbować ponownie? (Y/N)");
            Console.WriteLine();
        }
        #endregion
    }
}
