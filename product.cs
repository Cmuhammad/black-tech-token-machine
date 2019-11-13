using System;
using System.Collections.Generic;
using System.Text;

namespace BlackTechSmartVending.Models
{
    public class Product {
        
        public int Price { get; set;}

        
        public string Name { get; set;}

        public Product()
        {

        }
        
        public Product(int price, string name)
        {
            Price = price;
            Name = name; 
        }


    }
}
