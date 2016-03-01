using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{    
        class Author
        {
            string author;

            public string valAuthor
            {
                get { return author; }
                set { author = value; }
            }

            public void show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Автор: {0}", author);
                Console.ResetColor();

            }
        }
    }
