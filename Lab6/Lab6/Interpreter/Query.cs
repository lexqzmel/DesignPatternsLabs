using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Interpreter
{
    public class Query
    {
        private readonly string _query;

        public Query(string query)
        {
            _query = query;
        }

        public List<string> GetKeywords()
        {
            return _query.Split(new[] { "AND", "OR" }, StringSplitOptions.None)
                .Select(keyword => keyword.Trim())
                .ToList();
        }

        public string GetLogicalOperator()
        {
            return _query.Contains("AND") ? "AND" : "OR";
        }
    }
}
