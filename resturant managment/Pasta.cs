using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_managment
{
    public class Pasta : Food
    {
        private int _volume;
        public Pasta(string name, int price, int stock,int volume) : base(name, price, stock)
        {
            Volume = volume;
        }
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("wrong slice");
                }
                _volume = value;
            }
        }
        public override void SetPrice(int price)
        {
            if (price > 300)
            {
                throw new Exception("price cannot more than 300...");
            }
            base.SetPrice(price);
        }
    }
}
