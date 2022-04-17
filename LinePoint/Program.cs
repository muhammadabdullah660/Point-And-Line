using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinePoint.BL;
using LinePoint.UI;
namespace LinePoint
{
    class Program
    {
        static void Main ()
        {
            MyLine newLine = new MyLine();
            int op = 0;
            while (op < 10)
            {
                clearScreen();
                op = mainMenu();
                if (op == 1)
                {
                    clearScreen();
                    newLine = MyPointUI.makeLineInput();
                }
                else if (op == 2)
                {
                    clearScreen();
                    MyPointUI.updateBeginPoint(ref newLine);
                }
                else if (op == 3)
                {
                    clearScreen();
                    MyPointUI.updateEndPoint(ref newLine);
                }
                else if (op == 4)
                {
                    clearScreen();
                    MyPointUI.showBeginPoint(ref newLine);
                }
                else if (op == 5)
                {
                    clearScreen();
                    MyPointUI.showEndPoint(ref newLine);
                }
                else if (op == 6)
                {
                    clearScreen();
                    MyLineUI.getLength(ref newLine);
                }
                else if (op == 7)
                {
                    clearScreen();
                    MyLineUI.getGradient(ref newLine);
                }
                else if (op == 8)
                {
                    clearScreen();
                    MyPointUI.distanceEnd();
                }
                else if (op == 9)
                {
                    clearScreen();
                    MyPointUI.distanceEnd();
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
    }
}
