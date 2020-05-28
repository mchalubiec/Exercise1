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
                if (!String.IsNullOrEmpty(act.userString))
                {
                    act.StringToArray();
                    act.Validate();
                    if (act.validate == true)
                    {
                        act.ConvertArray();
                        act.WriteSeries();
                        act.WriteEven();
                        act.WriteOdd();
                        act.WriteSum();
                        do
                        {
                            act.Question();
                            if (act.endKey.Key == ConsoleKey.N)
                            {
                                Environment.Exit(0);
                            }
                            if (act.endKey.Key != ConsoleKey.Y && act.endKey.Key != ConsoleKey.N)
                            {
                                msg.YouDoItWrong();
                            }
                        }
                        while (act.endKey.Key != ConsoleKey.Y);
                    }
                    else { msg.BadSeries(); }
                }
                else { msg.EmptyString(); }
            }
            while (exit == true);
        }
    }
}
