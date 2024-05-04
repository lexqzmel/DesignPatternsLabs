using Lab6.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProducerExpression : AbstractExpression
{
    private readonly string _producer;

    public ProducerExpression(string producer)
    {
        _producer = producer;
    }

    public override List<Pill> Interpret(List<Pill> pills)
    {
        return pills.Where(pill => pill.Producer.Equals(_producer)).ToList();
    }
}
