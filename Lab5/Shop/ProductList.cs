using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Shop
{
    class ProductList : IAbstractCollection
    {

        private List<Product> listProduct = new List<Product>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return listProduct.Count; }
        }

        public void AddProduct(Product employee)
        {
            listProduct.Add(employee);
        }
        public Product GetProduct(int IndexPosition)
        {
            return listProduct[IndexPosition];
        }
    }
}
