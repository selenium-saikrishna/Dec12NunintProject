using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day22
{
    class Rectangle : Shapes
    {
        public void GetArea()
        {
            Console.WriteLine(length * width);
        }
        public void GetPerimeter()
        {
            Console.WriteLine(2 * (length + width));
        }
    }
}
