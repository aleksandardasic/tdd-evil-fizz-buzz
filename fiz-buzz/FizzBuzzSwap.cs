using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiz_buzz
{
    public class FizzBuzzSwap: ISwap
    {
        public IList<string> swap(IList<string> list)
        {
            int number;

            for (int i = 0; i < list.Count; i++)
            {
                var num = list[i];
                var success = Int32.TryParse(num, out number);
                if (success && number % 3 == 0 && number % 5 == 0)
                {
                    list[i] = "FizzBuzz";
                }
            }

            return list;
        }
    }
}
