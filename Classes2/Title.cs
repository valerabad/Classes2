using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Title
    {
        string title;
        public string valTitle
        {
            get { return title; }
            set { title = value; }
        }

        public void show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Название: {0}", title);
            Console.ResetColor();
        }      
    }
}
