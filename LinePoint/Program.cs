using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinePoint.BL;
namespace LinePoint
{
    class Program
    {


        static void Main ()
        {
            MyLine newLine = new MyLine();
            MyPoint begin = new MyPoint();
            MyPoint end = new MyPoint();
            int op = 0;
            while (op < 10)
            {
                clearScreen();
                op = mainMenu();
                if (op == 1)
                {
                    makeLine(ref newLine , ref begin , ref end);
                    clearScreen();
                }
                else if (op == 2)
                {
                    updateBeginPoint(ref newLine , ref begin);

                }
                else if (op == 3)
                {
                    updateEndPoint(ref newLine , ref end);

                }
                else if (op == 4)
                {
                    showBeginPoint(ref newLine);

                }
                else if (op == 5)
                {
                    showEndPoint(ref end);

                }
                else if (op == 6)
                {
                    double l = getLength(ref newLine);
                    Console.WriteLine($"Length = {l}");

                }
                else if (op == 7)
                {
                    double g = getGradient(ref newLine);
                    Console.WriteLine($"Gradient = {g}");

                }
                else if (op == 8)
                {
                    double d = distanceBegin(ref begin);
                    Console.WriteLine($"Distance = {d}");


                }
                else if (op == 9)
                {
                    double d = distanceEnd(ref end);
                    Console.WriteLine($"Distance = {d}");
                }
            }
        }
        static void clearScreen ()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        static int mainMenu ()
        {
            int op;
            Console.WriteLine("******************************");
            Console.WriteLine("        POINT AND LINE        ");
            Console.WriteLine("******************************");
            Console.WriteLine("1- Make a Line");
            Console.WriteLine("2- Update the Begin Point");
            Console.WriteLine("3- Update the End Point");
            Console.WriteLine("4- Show the Begin Point");
            Console.WriteLine("5- Show the End Point");
            Console.WriteLine("6- Get The Length Of Line");
            Console.WriteLine("7- Get The Gardient Of Line");
            Console.WriteLine("8- Find the distance of begin point from zero coordinates");
            Console.WriteLine("9- Find the distance of end point from zero coordinates");
            Console.WriteLine("10- Exit");
            op = int.Parse(Console.ReadLine());
            return op;

        }
        static void makeLine (ref MyLine newLine , ref MyPoint begin , ref MyPoint end)
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

            newLine = new MyLine(begin , end);


        }
        static void updateBeginPoint (ref MyLine newLine , ref MyPoint begin)
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
        static void updateEndPoint (ref MyLine newLine , ref MyPoint end)
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
        static void showBeginPoint (ref MyLine newLine)
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
        static void showEndPoint (ref MyPoint end)
        {
            Console.WriteLine("Co-ordinates of End Point:");
            Console.WriteLine("X Co-ordinate:");
            int x = end.getX();
            Console.WriteLine("Y Co-ordinate:");
            int y = end.getY();

            Console.WriteLine($"{x},{y}");
        }
        static double getLength (ref MyLine newLine)
        {
            double length = newLine.getLength();
            return length;
        }
        static double getGradient (ref MyLine newLine)
        {
            double gradient = newLine.getGradient();
            return gradient;
        }
        static double distanceBegin (ref MyPoint begin)
        {
            double d = begin.distancefromZero();
            return d;
        }
        static double distanceEnd (ref MyPoint end)
        {
            double d = end.distancefromZero();
            return d;
        }
    }
}
