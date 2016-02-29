using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Employee
    {
        string name;
        string lastname;        
        const double minSalary = 200d;
     
        public Employee(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
            
        }

        public void GetSalaryAndFee(Post post, int experience)
        {
            double salary = 0d, taxLevy = 0d, koef = 0, percent = 0;                       
            switch(post)
            {
                case Post.accountant:
                    koef = 500d;
                    percent = 12d;
                    break;
                case Post.director:
                    koef = 1000d;
                    percent = 20d;
                    break;
                case Post.manager:
                    koef = 100d;
                    percent = 5d;
                    break;
                case Post.secretary:
                    koef = 150d;
                    percent = 2d;
                    break;
                default:
                    koef = 1d;
                    percent = 1d;    
                    break;   
            }
            salary = minSalary * experience + koef;
            taxLevy = salary / 100d * percent;
            Console.WriteLine("Employee: {0} {1}\nPost: {2}\nSalary = {3}$\nTax levy = {4}$\n",name, lastname, post, salary,taxLevy) ;
        }
    }
}
