using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var listGenerator = new ListGenerator();

            IList<string> numberList = listGenerator.GenerateList();

            numberList = new FizzBuzzSwap().swap(numberList);

            numberList = new ThreeSwapper().swap(numberList);

            numberList = new Buzz().swap(numberList);

            var formatedNumberList = new OutputFormatter().Format(numberList);

            Console.Write(formatedNumberList);
        }
    }
}
