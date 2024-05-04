using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract List<Pill> Interpret(List<Pill> pills);
    }
}
