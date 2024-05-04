using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Interpreter
{
    public class PriceExpression : AbstractExpression
    {
        private readonly string _price;

        public PriceExpression(string price)
        {
            _price = price;
        }

        public override List<Pill> Interpret(List<Pill> pills)
        {
            return pills.Where(pill => pill.Price.Equals(_price)).ToList();
        }
    }
}
