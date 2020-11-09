using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Account
    {
        private string accName;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string acid;
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {
           

        }
        public Account(string accName,string acid,int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine("Account Name :" + accName);
            Console.WriteLine("Account Id :" + acid);
            Console.WriteLine("Account Balance :" + balance);
        }
        public void Deposit(int amount)
        {
            balance = amount;
            Console.WriteLine("Deposit Money :" + balance);
        }
        public void Withdraw(int amount)
        {
            balance = amount;
            Console.WriteLine("Withdraw Money :" + balance);
        }
    }
}
