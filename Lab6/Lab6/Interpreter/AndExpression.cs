using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Interpreter
{
    public class AndExpression : AbstractExpression
    {
        private readonly AbstractExpression _expression1;
        private readonly AbstractExpression _expression2;

        public AndExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public override List<Pill> Interpret(List<Pill> pills)
        {
            var result1 = _expression1.Interpret(pills);
            var result2 = _expression2.Interpret(result1);

            return result2;
        }
    }
}
