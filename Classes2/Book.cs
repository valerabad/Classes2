using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();
        public void addTitle(string title)
        {
            this.title.valTitle = title;           
        }
        public void addAuthor(string author)
        {
            this.author.valAuthor = author;
        }
        public void addContent(string content)
        {
            this.content.valContent = content;
        }
    }

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
            Console.WriteLine("Содержание: {0}",content);
            Console.ResetColor();
        }
    }
}
