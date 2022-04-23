using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinePoint.BL;
using System.IO;
namespace LinePoint.DL
{
    class MyLineDL
    {
        public static void storeIntoFile (string path , MyLine L)
        {
            StreamWriter f = new StreamWriter(path , false);
            f.WriteLine(L.getBegin().getX() + "," + L.getBegin().getY() + "," + L.getEnd().getX() + "," + L.getEnd().getY());
            f.Flush();
            f.Close();
        }
        public static bool loadFromFile (string path , ref MyLine newLine)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    int x = int.Parse(splittedRecord[0]);
                    int y = int.Parse(splittedRecord[1]);
                    MyPoint begin = new MyPoint(x , y);
                    x = int.Parse(splittedRecord[2]);
                    y = int.Parse(splittedRecord[3]);
                    MyPoint end = new MyPoint(x , y);
                    newLine = new MyLine(begin , end);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
