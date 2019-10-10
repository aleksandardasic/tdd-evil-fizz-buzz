using System;
using System.Collections.Generic;
using fiz_buzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fiz_buzz_tests
{
    [TestClass]
    public class OutputFormatterTest
    {
        [TestMethod]
        public void GivenAListOfStringsItFormatsItIntoString()
        {
            List<string> words = new List<string>();
            words.Add("first");
            words.Add("second");

            OutputFormatter outputFormatter = new OutputFormatter();

            Assert.AreEqual("first,second", outputFormatter.Format(words));
        }
    }
}
