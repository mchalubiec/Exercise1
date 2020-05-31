namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions act = new Actions();

            while (true)
            {
                act.GetStringAndValidate();
                act.ConvertString();
                if (act.validate == true)
                {
                    act.DisplayTasks();
                    act.EndOrAgain();
                }
            }
        }
    }
}
