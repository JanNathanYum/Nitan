using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplicationYumol
{
    internal abstract class Iitem
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;
      
        public abstract double GetChange();
        public abstract double GetTotalPrice();

        public abstract void setPayment(double amount);
    }
}
