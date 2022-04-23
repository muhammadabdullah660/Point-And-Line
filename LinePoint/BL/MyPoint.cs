using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinePoint.BL
{
    class MyPoint
    {
        private int x;
        private int y;
        public MyPoint ()
        {
            x = 0;
            y = 0;
        }
        public MyPoint (int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX ()
        {
            return this.x;
        }
        public int getY ()
        {
            return this.y;
        }
        public void setX (int x)
        {
            this.x = x;
        }
        public void setY (int y)
        {
            this.y = y;
        }
        public void setXY (int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public double distanceWithCords (int x , int y)
        {
            double distanceChords;
            distanceChords = Math.Pow(this.x - x , 2) + Math.Pow(this.y - y , 2);
            distanceChords = Math.Sqrt(distanceChords);
            return distanceChords;
        }
        public double distanceWithObjects (MyPoint myPoint)
        {
            double distanceObject;
            distanceObject = Math.Pow(this.x - myPoint.x , 2) + Math.Pow(this.y - myPoint.y , 2);
            distanceObject = Math.Sqrt(distanceObject);
            return distanceObject;
        }
        public double distancefromZero ()
        {
            double distanceZero;
            distanceZero = Math.Pow(this.x , 2) + Math.Pow(this.y , 2);


            distanceZero = Math.Sqrt(distanceZero);
            return distanceZero;
        }
    }
}
