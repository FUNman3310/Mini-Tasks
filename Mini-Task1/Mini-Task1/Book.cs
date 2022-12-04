using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Task1
{
    public class Book : Product
    {
        public string AuthorName { get; set; }  

        public int PageCount { get; set; }

        private static double _totalincome;


        static Book()
        {
            _totalincome = 0;
        }

        public Book(string name, double price, string authorName,int pageCount )
        {
            base.Name = name;
            base.Price = price;
            this.AuthorName = authorName;
            this.PageCount = pageCount; 
            
        }


        public override void Sell()
        {
            Count--;
            TotalInCome();
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name {Name} PageCount {PageCount} Price {Price} Count {Count} Id {Id} AuthorName {AuthorName} TotalInCome {_totalincome} ");
        }

        public override double TotalInCome()
        {
            _totalincome += Price;
            return _totalincome;
        }



    }
}
