using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student();
            ob1.student("Nura Jannat Rakhi","19-40042-1","CSE",3.83f);
            ob1.ShowStudentInfo();
            Book ob2 = new Book();
            ob2.book("Himu", "Humayun Ahmed", "121", "Fiction",6);
           
            Library ob3 = new Library();
            ob3.Library("AIUB Library", "Kuratoli", 5);
            ob3.ShowLibraryInfo();

            Account ob4 = new Account();
            ob4.account("My Account", "18-303-2020", 20000);
            ob4.ShowAccountInfo();
            ob4.Deposit(2000);
            ob4.Withdraw(100);




        }
    }
}
