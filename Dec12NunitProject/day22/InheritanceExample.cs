using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day22
{
    [TestFixture]
    public class InheritanceExample
    {
        [Test]
        public void InheritanceMethod()
        {
            Rectangle r = new Rectangle();
            r.GetData(20, 10);
            r.GetArea();
            r.GetPerimeter();

        }
    }
}
