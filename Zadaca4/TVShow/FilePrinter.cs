using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TVShow
{
    public class FilePrinter : IPrinter
    {
      

        public string FileName { get; private set; }
        public FilePrinter(string fileName)
        {
            FileName = fileName;
        }
        public void Print(string text)
        {
            using (var writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine(text);
            }
        }
    
    }
}
