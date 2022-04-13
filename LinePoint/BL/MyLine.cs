using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinePoint.BL
{
    class MyLine
    {
        public MyPoint begin;
        public MyPoint end;
        public MyLine (MyPoint begin , MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public MyLine ()
        {
            this.begin = null;
            this.end = null;
        }
        public MyPoint getBegin ()
        {
            return this.begin;
        }
        public MyPoint getEnd ()
        {
            return this.end;
        }
        public void setBegin (MyPoint begin)
        {
            this.begin = begin;
        }
        public void setEnd (MyPoint end)
        {
            this.end = end;
        }
        public double getLength ()
        {
            double length = begin.distanceWithObjects(end);
            return length;
        }
        public double getGradient ()
        {
            double m = (this.end.y - this.begin.y) / (this.end.x - this.begin.x);
            return m;
        }

    }
}
