using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
    }
}
