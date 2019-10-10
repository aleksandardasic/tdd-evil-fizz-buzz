using System.Collections.Generic;
using System.Linq;
using fiz_buzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fiz_buzz_tests
{
    [TestClass]
    public class ThreeSwapperTests
    {
        [TestMethod]
        public void FirstElementIsThreeAndIsReplaced()
        {
            List<string> data = new List<string>()
            {
                "3"
            };

            var swapper = new ThreeSwapper();
            var result = swapper.swap(data);

            Assert.IsTrue(result.First() == "Fizz");
        }

        [TestMethod]
        public void OneElementDivisibleOneIsNot()
        {
            List<string> data = new List<string>()
            {
                "3",
                "4"
            };

            var swapper = new ThreeSwapper();
            var result = swapper.swap(data);

            Assert.IsTrue(result[0] == "Fizz" && result[1] == "4");
        }
    }
}
