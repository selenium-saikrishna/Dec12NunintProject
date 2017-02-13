using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day26
{
    [TestFixture]
    [Parallelizable]
    public class TestClass1
    {
       /* public static IEnumerable<String> Browsertobeused()
        {
            String[] browser = { "firefox ", "chrome", "ie" };
            foreach (String x in browser)
                yield return x;
        }*/
        public static object[] getdata()
        {
            object[][] data = new object[3][];
            data[0] = new object[1];
            data[0][0] = "firefox1";

            data[1] = new object[1];
            data[1][0] = "ie1";

            data[2] = new object[1];
            data[2][0] = "chrome1";

            return data;

        }
        [Test,TestCaseSource("getdata")]
        //[TestCaseSource("Browsertobeused")]
        public void TestMethod(String browser)
        {
            Console.WriteLine(browser);
        }
    }
}
