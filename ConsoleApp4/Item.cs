using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Item:IMarketableProduct
    {
        public string Product { get; set; }
        public int Number { get; set; }
        public readonly int Id;
        private static int _id = 0;
        public Item()
        {
            _id++;
            Id = _id;
        }

        public void ShowProducts()
        {
            throw new NotImplementedException();
        }

        public string ProductSales()
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void ChangeProductInfo()
        {
            throw new NotImplementedException();
        }

        public string ProductForCategory()
        {
            throw new NotImplementedException();
        }

        public string ProductForPrice()
        {
            throw new NotImplementedException();
        }

        public void ShowProductForName()
        {
            throw new NotImplementedException();
        }
    }
