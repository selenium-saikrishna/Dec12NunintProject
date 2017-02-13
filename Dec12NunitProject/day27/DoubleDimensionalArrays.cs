using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day27
{
    [TestFixture]
    public class DoubleDimensionalArrays
    {
        [Test]
        public void DoubledimensionalTest()
        {
            Object[][] str = new Object[2][];
            str[0] = new String[3];
            str[1] = new String[3];

            str[0][0] = "selenium";
            str[0][1] = 10;
            str[0][2] = true;

            str[1][0] = 15.56;
            str[1][1] = 'a';
            str[1][2] = "cidedui";

            for(int i=0;i<str.Length;i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    Console.Write(str[i][j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
