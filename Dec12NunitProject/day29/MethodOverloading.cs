using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day29
{
    [TestFixture]
    public class MethodOverloading
    {
        public void SumAll(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void SumAll(double a,double b)
        {
            Console.WriteLine(a + b);
        }
        public void SumAll(String a,String b)
        {
            Console.WriteLine(a + b);
        }
        [Test]
        public void MethodOverloadingTest()
        {
            SumAll(10, 20);
            SumAll(10.45, 56.75);
            SumAll("Hello ", "Selenium");
        }
    }
}
