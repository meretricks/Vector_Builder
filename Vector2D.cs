using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Builder
{
    public struct Vector2D
    {
        public int X { get; set; }
        public int Y {  get; set; }

        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2D Empty { get { return new Vector2D(0, 0); } }

        public System.Drawing.Point ToPoint()
        {
            return new System.Drawing.Point(X, Y);
        }
    }
}
