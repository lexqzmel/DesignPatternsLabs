using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Interpreter
{
    public class Context
    {
        private readonly List<Pill> _pills;

        public Context(List<Pill> pills)
        {
            _pills = pills;
        }

        public List<Pill> ExecuteQuery(string query)
        {
            var keywords = new Query(query).GetKeywords();
            var logicalOperator = new Query(query).GetLogicalOperator();
            AbstractExpression expression1 = null;
            AbstractExpression expression2 = null;

            for (var i = 0; i < keywords.Count; i++)
            {
                var keyword = keywords[i];

                if (keyword.StartsWith("title:"))
                {
                    expression1 = new TitleExpression(keyword.Substring(6));
                }
                else if (keyword.StartsWith("producer:"))
                {
                    expression1 = new ProducerExpression(keyword.Substring(7));
                }
                else if (keyword.StartsWith("price:"))
                {
                    expression1 = new PriceExpression(keyword.Substring(6));
                }
                else if (keyword.StartsWith("type:"))
                {
                    expression1 = new TypeExpression(int.Parse(keyword.Substring(5)));
                }

                if (i == 0)
                {
                    expression2 = expression1;
                }
                else
                {
                    if (logicalOperator == "OR")
                    {
                        expression2 = new OrExpression(expression2, expression1);
                    }
                    else
                    {
                        expression2 = new AndExpression(expression2, expression1);
                    }
                }
            }
            if (expression2 == null)
            {
                return _pills;
            }

            return expression2.Interpret(_pills);
        }
    }

}
