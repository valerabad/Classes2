using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Adress
    {
        string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (value != null)
                    country = value;
                else
                    country = "null";
            }
        }

        int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value >= 0)
                    index = value;
                else
                    if (value < 0)
                        value = 0;
            }

        }
        string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (value != null)
                    city = value;
                else
                    city = "null";
            }
        }
        string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        int house;
        public int House
        {
            get { return house; }
            set { house = value; }
        }

        int apartment;
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

    }

    

}
