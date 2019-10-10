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
            expectedlist.Add("1");
            expectedlist.Add("Buzz");
            expectedlist.Add("7");
            expectedlist.Add("Buzz");
            var newlist = new Buzz().swap(list);
            for (int i = 0; i < expectedlist.Count; i++)
            {
                Assert.AreEqual(expectedlist[i], newlist[i]);
            }

        }
    }
}