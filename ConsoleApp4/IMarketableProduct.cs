using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IMarketableProduct
    {
        void ShowProducts();
        string ProductSales();
        void AddProduct(Product product);
        void ChangeProductInfo();
        string ProductForCategory();
        string ProductForPrice();
        void ShowProductForName();
    }
}
