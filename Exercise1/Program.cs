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
            Actions act = new Actions();


            do
            {
                act.Start();
                if (act.validate == true)
                {
                    act.ConvertString();
                    if (act.validate == true)
                    {
                        act.Display();
                        do
                        {
                            act.End();
                        }
                        while (act.exit == true);
                    }
                }
            }
            while (act.exit == false);
        }
    }
}
