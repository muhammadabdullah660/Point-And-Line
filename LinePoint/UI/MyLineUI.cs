using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinePoint.BL;
namespace LinePoint.UI
{
    class MyLineUI
    {
        public static void getLength (ref MyLine newLine)
        {
            double length = newLine.getLength();
            Console.WriteLine($"Length = {length}");
        }
        public static void getGradient (ref MyLine newLine)
        {
            double gradient = newLine.getGradient();
            Console.WriteLine($"Gradient = {gradient}");
        }

    }
}
