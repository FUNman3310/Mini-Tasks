using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Task1
{
    public abstract class Product
    {
        private static int _counter;
        private double _price;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get { return _price; }
            set
            {
                if (value>0&&value<100000)
                {
                    _price = value;
                } 
            } 
        }

        public int Count { get; set; }

        static Product()
        {
            _counter = 0;
        }

        public Product()
        {
            _counter++;
            this.Id = _counter;
            this.Count = 1000;
        }


        public abstract double TotalInCome();
       
        
        

        public abstract void Sell();

        public abstract void ShowInfo();







    }
}
