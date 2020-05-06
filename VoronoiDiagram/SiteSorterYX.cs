using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiDiagram
{
    class SiteSorterYX : IComparer<Site>
    {
        public int Compare(Site p1, Site p2)
        {
            PointF s1 = p1.coord;
            PointF s2 = p2.coord;
            if (s1.Y < s2.Y) return -1;
            if (s1.Y > s2.Y) return 1;
            if (s1.X < s2.X) return -1;
            if (s1.X > s2.X) return 1;
            return 0;
        }
    }
}
