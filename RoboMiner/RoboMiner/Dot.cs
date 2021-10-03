using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboMiner
{
    public class Dot
    {
        public Dot(int x, int y)
        {
            Coord.X = x;
            Coord.Y = y;
        }

        public Dot(Coord coord)
        {
            Coord = coord;
        }

        public Coord Coord { get; private set; }

        public Material Material { get; set; }
    }
}
