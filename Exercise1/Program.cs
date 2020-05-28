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

            bool exit = true;
            do
            {
                act.Go();
                if (!String.IsNullOrEmpty(act.someSeries))
                {
                    act.ConvertSeries();
                    act.WriteSeries();
                    act.Even();
                    act.Odd();
                    act.Sum();
                    do
                    {
                        act.Question();
                        if (act.klawisz.Key == ConsoleKey.N)
                        {
                            Environment.Exit(0);
                        }
                        if (act.klawisz.Key != ConsoleKey.Y || act.klawisz.Key != ConsoleKey.N)
                        {
                            msg.YouDoItWrong();
                        }
                    }
                    while (act.klawisz.Key != ConsoleKey.Y);
                }
                else { msg.EmptySeries(); }
            }
            while (exit == true);
        }
    }
}
