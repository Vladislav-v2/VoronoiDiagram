using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiDiagram
{
    class Edge
    {
        public double a = 0, b = 0, c = 0;
        public Site[] ep;
        public Site[] reg;
        public int edgenbr;

        public Edge()
        {
            ep = new Site[2];
            reg = new Site[2];
        }
    }
}
