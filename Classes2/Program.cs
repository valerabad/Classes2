using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number task:");
            int task =  Convert.ToInt16(Console.ReadLine());
            switch (task)
            {
                case 0:
                    {
                        Adress adressObj = new Adress();
                        adressObj.Country = "Ukraine";
                        adressObj.City = "Dnipro";
                        adressObj.Index = 49000;
                        adressObj.Street = "Lenina";
                        adressObj.House = 31;
                        adressObj.Apartment = 22;
                        Console.WriteLine("Country: {0}\nCity: {1}\nIndex: {2}\nStreet: {3}\nHouse: {4}\nApartment: {5}",
                        adressObj.Country, adressObj.City, adressObj.Index, adressObj.Street, adressObj.House, adressObj.Apartment);
                    }
                    break;
                case 1:
                    {
                        double side1 = Convert.ToDouble(Console.ReadLine());
                        double side2 = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(side1,side2);
                        Console.WriteLine("Area = {0}\tPerimetr = {1}",rectangle.Area,rectangle.Perimetr);
                    }
                    break;
                case 2:
                    {
                        Book book = new Book();

                        Title t = new Title();
                        t.valTitle = Console.ReadLine();
                        Author a = new Author();
                        a.valAuthor = Console.ReadLine();
                        Content c = new Content();
                        c.valContent = Console.ReadLine();

                        book.addAuthor(c.valContent);
                        book.addContent(a.valAuthor);
                        book.addTitle(t.valTitle);

                        t.show();
                        a.show();
                        c.show();                       
                    }
                    break;
                case 3:
                    {
                        Point[] p3 = new Point[3];
                        p3[0] = new Point(1, 2, "A");
                        p3[1] = new Point(3, 4, "B");
                        p3[2] = new Point(5, 2, "C");                        

                        Point[] p4 = new Point[4];
                        p4[0] = new Point(1, 2, "A");
                        p4[1] = new Point(3, 4, "B");
                        p4[2] = new Point(6, 5, "C");
                        p4[3] = new Point(3, 4, "D");                       

                        Point [] p5 = new Point[5];
                        p5[0] = new Point(1, 2, "A");
                        p5[1] = new Point(3, 4, "B");
                        p5[2] = new Point(6, 5, "C");
                        p5[3] = new Point(3, 4, "D");
                        p5[4] = new Point(10, 10, "E"); 
                      
                        Figure figure1 = new Figure(p3);
                        figure1.PerimetrCalculator();

                        Figure figure2 = new Figure(p4);
                        figure2.PerimetrCalculator();

                        Figure figure3 = new Figure(p5);
                        figure3.PerimetrCalculator();
                    }
                    break;
            }
            
        
            Console.ReadKey();  
        }
    }
}

