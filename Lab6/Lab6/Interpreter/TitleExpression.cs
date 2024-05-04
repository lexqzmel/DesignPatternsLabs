using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Interpreter
{
    public class TitleExpression : AbstractExpression
    {
        private readonly string _title;

        public TitleExpression(string title)
        {
            _title = title;
        }

        public override List<Pill> Interpret(List<Pill> pills)
        {
            return pills.Where(pill => pill.Title.Equals(_title)).ToList();
        }
    }
}
