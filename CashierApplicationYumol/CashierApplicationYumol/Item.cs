using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplicationYumol
{
    internal class Item : Iitem
    {
        private double item_discount, change, discounted_price, payment_amount;
        private int Quantity;


        public Item(string name, double price, int quantity, double discount)
        {
           this.item_name = name;
           this.item_discount = price;
           this.Quantity = quantity;
           this.discounted_price = discount;
          
        }


        public override double GetTotalPrice()
        {
            discounted_price = discounted_price * 0.01;
            item_discount = item_discount - (item_discount * discounted_price);
            total_price = item_discount * Quantity;
             
            return total_price;
        }

        public override double GetChange() { 
        change = payment_amount - total_price;

            return change;
        
        }

        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }

    }


}
