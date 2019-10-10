using System.Collections.Generic;

namespace fiz_buzz
{
    public class ThreeSwapper : ISwap
    {
        public IList<string> swap(IList<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (int.TryParse(list[i], out int number) && number % 3 == 0)
                {
                    list[i] = "Fizz";
                }
            }
            return list;
        }
    }
}