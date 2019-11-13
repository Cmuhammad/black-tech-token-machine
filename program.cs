using System;
using BlackTechSmartVending;

namespace BlackTechSmartVending.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World")
            
            Product Grippos = new Product(price:2, name:"Grippos")

            Coin quarter = new Coin(25);

            product.buySnack(quarter);



    
        }

        public class Product
        {
            public string Name { get; set;}

            public int Price { get; set;}

            public Product(string name, int price)
            {
                Name = name;
                Price = price;
            }

            public buySnack(Coin coin )
            {
                if(coin.Value == 25)
                {
                    Console.WriteLine("I bought some chips");
                }

            }
        
        }
        public class coin
        {
            public int Value { get; set;}

            public Coin(int value)
            {
                Value = value;
            }
        }
    }

}