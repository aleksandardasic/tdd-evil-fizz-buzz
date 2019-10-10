using System.Collections.Generic;

namespace fiz_buzz
{
    public class ListGenerator
    {
        public List<string> GenerateList()
        {
            var list = new List<string>(100);

            for (int i = 1; i <= 100; i++)
            {
                list.Add(i.ToString());
            }

            return list;
        }
    }
}
