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
    
}
