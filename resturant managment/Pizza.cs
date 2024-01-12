using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_managment
{
    public class Pizza : Food
    {
        private int _slice;
        public Pizza(string name, int price, int stock,int slice) : base(name, price, stock)
        {
            Slice = slice;
        }
        public int Slice
        {
            get
            {
                return _slice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("wrong slice");
                }
                _slice = value;
            }
        }
        public override void SetPrice(int price)
        {
            if (price > 350)
            {
                throw new Exception("price cannot more than 350....");
            }
            base.SetPrice(price);
        }
    }
}
