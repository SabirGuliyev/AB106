using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Product
    {
        public string Name;
        public decimal Price;
        public decimal Cost;
        public int Stock;
        public decimal Income=0;

        public Product(string name, decimal price,decimal cost,int stock)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Stock = stock;
            
        }

        public void FillStock(int num)
        {
            Stock += num;
        }
        public void Sell()
        {
            Stock--;
            Income += Price - Cost;
        }
    }
}

//Product class:

//fields:
//Name,
//Price,
//Cost,
//Stock,
//Income deafult 0 olmalidir

//ctor(Name, Stock, Price, Cost)

//Methods
//FillStock(int num) mehsulun stockun artirmaq ucun

//Sell()  ishe dushdukde stock azalir income artir