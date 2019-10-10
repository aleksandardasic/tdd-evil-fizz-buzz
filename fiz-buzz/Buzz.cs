using System.Collections.Generic;

namespace fiz_buzz
{
    public class Buzz : ISwap
    {
        public IList<string> swap(IList<string> list)
        {
            List<string> newList = new List<string>();
            foreach (var s in list)
            {
                int i;
                if (int.TryParse(s, out i))
                {
                    if (i % 5 == 0)
                    {
                        newList.Add("Buzz");
                    }
                    else
                    {
                        newList.Add(i.ToString());
                    }
                }
                else newList.Add(s);
            }

            return newList;
        }
    }
}