using System;
using System.Collections.Generic;
using System.Text;

namespace TVShow
{
    public class TvException:Exception
    {
        public string Title { get; }

        public TvException(string title)
        {
            Title = title;
        }
        public TvException() { }

        public TvException(string title,string message):base(message)
        {
            Title = title;
        }
    }
}
