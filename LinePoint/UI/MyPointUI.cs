using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinePoint.BL;
namespace LinePoint.UI
{
    class MyPointUI
    {
        public static MyPoint begin = new MyPoint();
        public static MyPoint end = new MyPoint();
        public static MyLine makeLineInput ()
        {
            int x, y;
            Console.WriteLine("Enter Co-ordinates of Begin Point:");
            Console.WriteLine("Enter X Co-ordinate:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinate:");
            y = int.Parse(Console.ReadLine());
            // With Parameterized Constructor
            begin = new MyPoint(x , y);

            Console.WriteLine("Enter Co-ordinates of End Point:");
            Console.WriteLine("Enter X Co-ordinate:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinate:");
            y = int.Parse(Console.ReadLine());
            // With Default Constructor and Public Behaviors
            end = new MyPoint();
            end.setX(x);
            end.setY(y);

            MyLine newLine = new MyLine(begin , end);
            return newLine;
        }
        public static void updateBeginPoint (ref MyLine newLine)
        {
            Console.WriteLine("Enter Co-ordinates of Begin Point:");
            Console.WriteLine("Enter X Co-ordinate:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinate:");
            int y = int.Parse(Console.ReadLine());
            begin.setXY(x , y);
            newLine.setBegin(begin);
            Console.WriteLine("Point Updated");
        }
        public static void updateEndPoint (ref MyLine newLine)
        {
            Console.WriteLine("Enter Co-ordinates of End Point:");
            Console.WriteLine("Enter X Co-ordinate:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinate:");
            int y = int.Parse(Console.ReadLine());
            end.setXY(x , y);
            newLine.setEnd(end);
            Console.WriteLine("Point Updated");
        }
        public static void showBeginPoint (ref MyLine newLine)
        {
            MyPoint begin1 = new MyPoint();
            begin1 = newLine.getBegin();
            Console.WriteLine("Co-ordinates of Begin Point:");
            Console.WriteLine("X Co-ordinate:");
            int x = begin1.getX();
            Console.WriteLine("Y Co-ordinate:");
            int y = begin1.getY();

            Console.WriteLine($"{x},{y}");
        }
        public static void showEndPoint (ref MyLine newLine)
        {
            Console.WriteLine("Co-ordinates of End Point:");
            Console.WriteLine("X Co-ordinate:");
            int x = newLine.end.getX();
            Console.WriteLine("Y Co-ordinate:");
            int y = newLine.end.getY();

            Console.WriteLine($"{x},{y}");
        }
        public static void distanceBegin ()
        {
            double d = begin.distancefromZero();
            Console.WriteLine($"Distance = {d}");
        }
        public static void distanceEnd ()
        {
            double d = end.distancefromZero();
            Console.WriteLine($"Distance = {d}");
        }
    }
}
