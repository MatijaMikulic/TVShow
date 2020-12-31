using System;
using System.Collections.Generic;
using System.Text;

namespace TVShow
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
