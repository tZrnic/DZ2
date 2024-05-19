﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Product
    {
        public string Name { get; private set; }
        public string Price { get; private set; }
        public bool IsInStock { get; set; }

        public Product(string name, string price)
        {
            this.Name = name;
            this.Price = price;
            this.IsInStock = false;
        }
    }

    class ProductHandler
    {
        List<Product> products;

        public ProductHandler(List<Product> inventory)
        {
            products = inventory;
        }

        public void Restock(Product product) 
        {
            foreach (Product singleProduct in products)
            {
                if (product == singleProduct)
                    singleProduct.IsInStock = true;
            }
        }
        public void RemoveUnavailable()
        {
            products.RemoveAll(product => product.IsInStock == false);
        }
    }
}
