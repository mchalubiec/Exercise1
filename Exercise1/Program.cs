namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions act = new Actions();

            while (true)
            {
                act.Start();
                if (act.validate == true)
                {
                    act.ConvertString();
                    if (act.validate == true)
                    {
                        act.Display();
                        act.End();
                    }
                }
            }
        }
    }
}
