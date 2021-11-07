using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Builder.Pages.Components
{
    internal class Vector2Dcom : COModel
    {
        System.Drawing.Size COModel.Size { get; set; }

        public Vector2D Position { get; set; }
        public bool Over { get; set; }
        public System.Drawing.Rectangle Bounds = new System.Drawing.Rectangle();

        public Vector2Dcom(int x, int y)
        {
            Position = new Vector2D(x, y);
            Over = false;
            Bounds = new System.Drawing.Rectangle(Position.X - 8, Position.Y - 8, 16, 16);
        }

        public bool Contains(Vector2D position)
        {
            return (position.X >= Position.X - 8) && (position.Y >= Position.Y - 8) && (position.X <= Position.X + 8) && (position.Y <= Position.Y + 8);
        }

        public bool Contains(int x, int y)
        {
            return (x >= Position.X - 8) && (y >= Position.Y - 8) && (x <= Position.X + 8) && (y <= Position.Y + 8);
        }

        public void Draw(System.Drawing.Graphics g)
        {
            if (!Over)
                g.DrawImage(Properties.Resources.Vector2DMarker, Bounds);
            else
                g.DrawImage(Properties.Resources.Vector2DMarker_Over, new System.Drawing.Rectangle(Position.X - 11, Position.Y - 11, 22, 22));
        }
    }
}
