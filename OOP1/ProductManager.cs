using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //CRUD operations- create,read,update,delete
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");

        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi.");

        }

        public void Update(Product product) {

            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        


    }
}
