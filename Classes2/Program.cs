using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    enum Post : byte { director, secretary, accountant, manager };
  
    class Program
    {        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter number task 1-7 or other key for exit");
                int task;
                int.TryParse(Console.ReadLine(), out task);

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
                            Rectangle rectangle = new Rectangle(side1, side2);
                            Console.WriteLine("Area = {0}\tPerimetr = {1}", rectangle.Area, rectangle.Perimetr);
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

                            Point[] p5 = new Point[5];
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
                    case 4:
                        User user = new User("testLogin", "testName", "testLastname", 22, "27.02.16");
                        user.showUser();
                        break;
                    case 5:
                        Converter converter = new Converter(27.0d, 30.0d, 0.33d);
                        Console.WriteLine("Enter\n1.USD \n2.EUR \n3.RUB");
                        int typeCurrency;
                        double amount;
                        Console.WriteLine("Enter currency");
                        int.TryParse(Console.ReadLine(), out typeCurrency);
                        Console.WriteLine("Enter amount UAH");
                        double.TryParse(Console.ReadLine(), out amount);

                        switch (typeCurrency)
                        {
                            case 1:
                                converter.UAHToCurrency(1, amount);
                                break;
                            case 2:
                                converter.UAHToCurrency(2, amount);
                                break;
                            case 3:
                                converter.UAHToCurrency(3, amount);
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Convert to UAH:");

                        converter.CurrencyToUAH(1, amount); // usd
                        converter.CurrencyToUAH(2, amount); // eur
                        converter.CurrencyToUAH(3, amount); // rub

                        break;
                    case 6:
                        Employee employee = new Employee("Valeriy", "Baditsa");
                        employee.GetSalaryAndFee(Post.manager, 4);
                        employee.GetSalaryAndFee(Post.director, 10);
                        employee.GetSalaryAndFee(Post.accountant, 2);
                        break;
                    case 7:
                        Invoice invoice = new Invoice(1, "testCustomer", "testPovider");
                        invoice.percentVAX = 12d;
                        invoice.AddPurchase("ld3ID", 10);
                        invoice.AddPurchase("ld87", 2);
                        invoice.ResultCost();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}

