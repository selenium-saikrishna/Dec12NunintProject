using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day21
{
    [TestFixture]
    public class SoftQ
    {
        int fee;
        String course;
        public void CourseDetails(int fee,String course)
        {
            this.fee = fee;
            this.course = course;
        }

        [Test]
        public void TestMethod()
        {
            SoftQ s = new SoftQ();
            s.CourseDetails(5000, "Selenium");
            Console.WriteLine(s.fee + "---" + s.course);
        }
    }
}
