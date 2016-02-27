using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class User
    {
        string login;
        string name;
        string lastname;
        int age;
        public readonly string dateFill;

        public User(string login, string name, string lastname, int age, string dateFill)
        {
            this.login = login;
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.dateFill = dateFill;
        }

        public void showUser()
        {
            Console.WriteLine("Login: {0}\nName: {1}\nLastname: {2}\nAge: {3}\nDate: {4}",login, name, lastname, age, dateFill);
        }
    }
}
