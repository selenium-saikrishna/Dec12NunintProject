using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day28
{
    [TestFixture]
    public class Hsbc : Bank
    {
        public void debit()
        {
            Console.WriteLine("Debting process");

        }
        public void credit()
        {
            Console.WriteLine("Credit Policy");
        }
        public void moneytransfer()
        {
            Console.WriteLine("Money transfer");
        }
        [Test]
        public void InterfaceMethod()
        {
            Hsbc h = new Hsbc();
            h.moneytransfer();
            h.debit();
            h.credit();

        }
    }
}
