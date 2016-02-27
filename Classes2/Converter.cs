using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Converter
    {
        double usd;
        double eur;
        double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double UAHToCurrency(int typeCurrency, double amountUAH)
        {
            double result;
            switch (typeCurrency)
            {
                case 1:
                    result = amountUAH / usd;
                    Console.WriteLine("{0} uah = {1} USD",amountUAH, result);
                    break;
                case 2:
                    result = amountUAH / eur;
                    Console.WriteLine("{0} uah = {1} EUR", amountUAH, result);
                    break;
                case 3:
                    result = amountUAH / rub;
                    Console.WriteLine("{0} uah = {1} RUB", amountUAH, result);
                    break;
                default: 
                    result = 0d;
                    break;
            }
            return result;
        }

        public double CurrencyToUAH(int typeCurrency, double amountCurrency)
        {
            double result;
            switch (typeCurrency)
            {
                case 1:                   
                    result = amountCurrency * usd;
                    Console.WriteLine("{0} USD = {1} hrn", amountCurrency, result);
                    break;
                case 2:
                    result = amountCurrency * eur;
                    Console.WriteLine("{0} EUR = {1} hrn", amountCurrency, result);
                    break;
                case 3:                   
                    result = amountCurrency * rub;
                    Console.WriteLine("{0} RUB = {1} hrn", amountCurrency, result);
                    break;
                default: result = 0d;
                    break;
            }
            return result;
        }
    }
}
