using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_managment
{
    public static class OrderManagment
    {
        private static List<Pasta> _pastas = new();
        private static List<Pizza> _pizzas = new();
        public static void AddPasta(string name,int price,int stock,int volume)
        {
            var pasta = new Pasta(name, price, stock, volume);
            _pastas.Add(pasta);
        }
        public static void AddPizza(string name,int price,int stock, int slice)
        {
            var pizza = new Pizza(name, price, stock, slice);
            _pizzas.Add(pizza);
        }
        public static void ReamovePasta(string name)
        {
            var pasta = _pastas.FirstOrDefault(_ => _.Name == name);
            if(pasta is null)
            {
                throw new Exception("wrong pasta name");
            }
            _pastas.Remove(pasta);
        }
        public static void ReamovePizza(string name)
        {
            var pizza = _pizzas.FirstOrDefault(_ => _.Name == name);
            if(pizza is null)
            {
                throw new Exception("wrong pizza name");
            }
            _pizzas.Remove(pizza);
        }
        public static List<Pasta> GetPastas()
        {
            return _pastas;
        }
        public static List<Pizza> GetPizzas()
        {
            return _pizzas;
        }
        public static void OrderPasta(string name)
        {
            var pasta = _pastas.FirstOrDefault(_ => _.Name == name);
            if(pasta is null)
            {
                throw new Exception("pasta not found");
            }
            pasta.Sold();
        }
        public static void OrderPizza(string name)
        {
            var pizza = _pizzas.FirstOrDefault(_ => _.Name == name);
            if(pizza is null)
            {
                throw new Exception("pizza not found");
            }
            pizza.Sold();
        }
    }
}
