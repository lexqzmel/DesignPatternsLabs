using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Interpreter
{
    public class TypeExpression : AbstractExpression
    {
        private readonly int _type;

        public TypeExpression(int type)
        {
            _type = type;
        }

        public override List<Pill> Interpret(List<Pill> pills)
        {
            return pills.Where(pill => pill.Type == _type).ToList();
        }
    }
}
