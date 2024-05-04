using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Shop
{
    internal class IAbstractIterator
    {
        Product First { get; }

        Product Next { get; }
        bool IsCompleted { get; }
    }
}
