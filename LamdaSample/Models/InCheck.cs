using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaSample.Models
{
    public class InCheck
    {
        public string Filed { get; set; }
        public string ErrorRule { get; set; }
        public bool isValid { get; set; } = true;
    }
}
