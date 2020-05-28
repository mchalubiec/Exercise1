using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages msg = new Messages();
            Actions act = new Actions();        


            msg.Command();
            act.ReadSeries();
            act.ConvertSeries();
            //foreach (var cell in act.ints)
            //    if (String.IsNullOrEmpty(cell))
            //    {
            //        msg.EmptySeries();
            //        msg.Command();
            //    }

            // parzyste
            act.Even();

            // nieparzyste
            act.Odd();

            // suma elementów tablicy
            act.Sum();
            

            Console.WriteLine("Czy chcesz spróbować ponownie? (Y/N)");
            ConsoleKeyInfo klawisz;
            klawisz = Console.ReadKey();
            if (klawisz.Key == ConsoleKey.Y)
            {
                msg.Command();
            }
            if (klawisz.Key == ConsoleKey.N)
            {
                Environment.Exit(0);
            }
            if (klawisz.Key != ConsoleKey.Y && klawisz.Key != ConsoleKey.N)
            {

                Console.WriteLine("Czy chcesz spróbować ponownie? (Y/N)");
            }
            else Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
