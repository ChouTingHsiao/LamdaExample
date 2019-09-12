using LamdaSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaSample.Rules
{
    public class StringRule
    {
        public Dictionary<string, Predicate<InCheck>> GetRuleList()
        {
            Dictionary<string, Predicate<InCheck>> dic = new Dictionary<string, Predicate<InCheck>>();

            dic.Add("is_equal_to_A", x => x.Filed == "A" );

            dic.Add("is_null", x => !string.IsNullOrEmpty(x.Filed));

            return dic;
        }
      
    }
}
