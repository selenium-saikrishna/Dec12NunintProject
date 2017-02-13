using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day27
{
    [TestFixture]
    public class Pattern
    {
        [Test]
        public void TestMethod()
        {
            int r = 4;
            int c = 3;
            int l = 0;
            for (int i=1;i<=r;i++)
            {
                for(int j=c;j>=1;j--)
                {
                    Console.Write(' ');
                }
                c--;
                Console.Write('/');
                
                for (int k = 0; k <l;k++)
                {
                    Console.Write(' ');
                }
                Console.Write('\\');
                l += 2;
                Console.WriteLine();

            }
        }
    }
}
