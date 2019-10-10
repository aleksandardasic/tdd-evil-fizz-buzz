using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fiz_buzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fiz_buzz_tests
{
    [TestClass]
    public class ListGeneratorTests
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(50)]
        [DataRow(99)]
        public void NumberAtPositionIsCorrect(int position)
        {
            var listGenerator = new ListGenerator();
            var generateList = listGenerator.GenerateList();
            Assert.AreEqual(position+1, Int32.Parse(generateList[position]));
        }
    }
}
