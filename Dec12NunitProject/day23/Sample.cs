using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day23
{
    [TestFixture]
    public class Sample
    {
        [Test]
        public void SMethod()
        {
            Console.WriteLine("ABc");
            Assert.Ignore();
            Console.WriteLine("XYZ");
        }
    }
}
