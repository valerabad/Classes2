using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Content
    {
        string content;

        public string valContent
        {
            get { return content; }
            set { content = value; }
        }

        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Содержание: {0}", content);
            Console.ResetColor();
        }
    }
}
