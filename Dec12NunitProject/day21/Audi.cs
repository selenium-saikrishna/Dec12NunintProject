using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day21
{
    [TestFixture]
    public class Audi : Car
    {
        String model;
        public void Stop()
        {
            Console.WriteLine("This is to stop the car");
        }
        [Test]
        public void TestMethod()
        {
            Audi a = new Audi();
            a.model = "A4";
            a.Stop();
            a.price = 1111;
            a.Start();

        }
    }
}
