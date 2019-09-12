using LamdaSample.Models;
using LamdaSample.Rules;
using System;
using System.Collections.Generic;

namespace LamdaSample
{
    class Program
    {
        static void Main(string[] args)
        {
            InCheck item = new InCheck { Filed = "B" };

            InCheck checkitem = ExecuteAllCheck(item);

            if (!checkitem.isValid)
            {
                Console.WriteLine($"Execute {checkitem.ErrorRule} Fail");
            }

            Console.WriteLine("Execute Complete");
            Console.ReadLine();

        }

        public static InCheck ExecuteAllCheck(InCheck item)
        {
            Dictionary<string, Predicate<InCheck>> All_Rule = new StringRule().GetRuleList();

            List<string> ExecuteList = new List<string>();

            ExecuteList.Add("is_null");
            ExecuteList.Add("is_equal_to_A");


            foreach (string Execute_Rule in ExecuteList)
            {
                item.isValid = All_Rule[Execute_Rule](item);

                if (!item.isValid)
                {
                     item.ErrorRule = Execute_Rule;
                }
            }

            return item;
        }
    }
}
