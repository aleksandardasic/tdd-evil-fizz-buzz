using System;
using System.Collections;
using System.Collections.Generic;
using fiz_buzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fiz_buzz_tests
{


    [TestClass]
    public class BuzzUnitTest
    {
        [TestMethod]
        public void BuzzTEst()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("5");
            list.Add("7");
            list.Add("10");
            List<string> expectedlist = new List<string>();
            list.Add("1");
            list.Add("Buzz");
            list.Add("7");
            list.Add("Buzz");
            var newlist = new Buzz().swap(list);
            for (int i = 0; i < expectedlist.Count; i++)
            {
                Assert.AreEqual(expectedlist[i], newlist[i]);
            }

        }
    }

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