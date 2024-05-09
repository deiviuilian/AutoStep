using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSuite
{
    public class Commands
    {
        public string Type { get; set; }
       
        public dynamic Value { get; set; }

        public int Step { get; set; }

        public string NomeAutomacao { get; set; }
    }
}
