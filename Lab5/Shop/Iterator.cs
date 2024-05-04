using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Shop
{
    class Iterator : IAbstractIterator
    {
        private ProductList Collection;
        private int Current = 0;
        private readonly int Step = 1;

        public Iterator(ProductList Collection)
        {
            this.Collection = Collection;
        }
        public Product First()
        {
            Current = 0;
            return Collection.GetProduct(Current);
        }
        public Product Next()
        {
            Current += Step;
            if (!IsCompleted)
            {
                return Collection.GetProduct(Current);
            }
            else
            {
                return null;
            }
        }
        public bool IsCompleted
        {
            get { return Current >= Collection.Count; }
        }
    }
}
