using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Library
    {
        private string libName;
        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        private string libAddress;
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        private Book[] listOfBook;
       private int totalBook;
        
        public int TotalBook 
        { 
            get { return totalBook; }
            set { totalBook = value; }
        }
        public Library()
        {
            
        }
        public Library(string libName,string libAddress,int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            listOfBook = new Book[100];
        }
        public void ShowLibraryInfo()
        {
            Console.WriteLine("Library Name :" + libName);
            Console.WriteLine("Library Address :" + libAddress);
            Console.WriteLine("Library TotalBook :" + totalBook);
           

        }



    }
}
