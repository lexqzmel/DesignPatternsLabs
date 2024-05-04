using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Patern
{
    interface IVisitor
    {
        void Visit(Order order);
    }
}
