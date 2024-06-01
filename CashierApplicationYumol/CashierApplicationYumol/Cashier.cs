using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplicationYumol
{
    internal class Cashier : UserAccount
    {
        private string departmanent;

        public Cashier(string name, string department, string userName, string password) : base(name, userName, password)
        {
            this.full_name = name;
            this.departmanent = department;
            this.user_name = userName;
            this.user_password = password;
        }
        public override bool validateLogin(string username, string password)
        {
            if (user_name.Equals("cashier101") && password.Equals("12345"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getDepartment()
        {
            return departmanent;
        }

    }
}