using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Builder
{
    public static class RectCorrector
    {
        public static Rectangle Correct(this Rectangle r)
        {
            var x = r.X;
            var y = r.Y;

            var x2 = r.X + r.Width;
            var y2 = r.Y + r.Height;

            return new Rectangle(r.Width < 0 ? x2 : x, r.Height < 0 ? y2 : y, Math.Abs(r.Width), Math.Abs(r.Height));
        }
    }
}
