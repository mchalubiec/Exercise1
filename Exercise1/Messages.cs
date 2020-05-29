using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Messages
    {
        public void Command()
        {
            Console.ResetColor();
            Console.WriteLine("Podaj ciąg liczbowy (dowolnej długości), oddzielając cyfry przecinkiem: ");
        }
        public void EmptyString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie podałeś żadnego ciągu.");
        }
        public void BadSeries()
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
        public void YouDoItWrong()
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
    }
}
