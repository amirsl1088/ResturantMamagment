using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_managment
{
    public class Food
    {
        public Food(string name,int price,int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public string Name { get; set; }
        public int Price { get;private set; }
        public int Stock { get;private set; }
        public virtual void SetPrice(int price)
        {
            if (price <= 0)
            {
                throw new Exception("wrong price");
            }
            Price = price;
        }
        public  void SetStock(int stock)
        {
            if (stock < 0)
            {
                throw new Exception("wrong stock");
            }
            Stock = stock;
        }
        public void Sold()
        {
            if (Stock == 0)
            {
                throw new Exception("out of stock");
            }
            var newStock = Stock - 1;
            SetStock(newStock);
            Console.WriteLine($"price={Price}");
        }
    }
}
