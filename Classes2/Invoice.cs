using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Invoice
    {
        public double percentVAX {get; set;}
        readonly int account;
        readonly string customer;
        readonly string provider;

        public string article {get; set;}
        int quantity;
        public int Quantity
        {
            get { return quantity; }
            set 
            {
                if (value >= 0) quantity = value;
                else quantity = 0;
            }
        }
       
        public double amount {get; set;}
        Dictionary<string, double> articleCost = new Dictionary<string, double>();

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

            articleCost.Add("ld39edo", 100d);
            articleCost.Add("ld3ID", 400d);
            articleCost.Add("redBag12", 200d);
            articleCost.Add("ld87", 320.4d);
            articleCost.Add("ld921", 50.3d);
        }

        public void AddPurchase(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;

            double cost = 0d;
            articleCost.TryGetValue(this.article, out cost);
            this.amount += this.quantity * cost;                                                                                                                              
        }

        public void ResultCost()
        {
            double resultWithVAX = 0d, resultWithoutVAX = 0d;
            resultWithVAX = amount + amount / 100d * percentVAX;
            resultWithoutVAX = amount;
            Console.WriteLine("Клиент: {0} Поставщик: {1}", this.customer, this.provider);
            Console.WriteLine("Сумма с учётом НДС: {0}\nСумма без учёта НДС: {1}", resultWithVAX, resultWithoutVAX); 
        }
        
    }
}
