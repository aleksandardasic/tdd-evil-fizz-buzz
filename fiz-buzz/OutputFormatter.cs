using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiz_buzz
{
    public class OutputFormatter
    {
        public string Format(ICollection<string> words)
        {
            return string.Join(",", words);
        }
    }
}
