using System;

namespace Exercise1
{
    class Messages
    {
        #region Methods
        public void DisplayErrorText(string errorText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorText);
        }
        public void DisplayText(string text)
        {
            Console.ResetColor();
            Console.WriteLine(text);
        }
        #endregion
    }
}
