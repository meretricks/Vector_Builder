using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Builder.Pages.Components
{
    internal class Square2Dcom : COModel
    {

        public Color BackColor { get; set; }
        public Color BorderColor { get; set; }

        private SolidBrush backBrush;
        private Pen borderPen;

        public bool Selected { get; set; }
        public bool Over { get; set; }
        public Vector2D Position { get; set; }
        public Size Size { get; set; }

        public Square2Dcom(Vector2D topleft)
        {
            Selected = false;
            Position = topleft;
            BackColor = Color.FromArgb(100, Color.White);
            BorderColor = Color.DimGray;

            backBrush = new SolidBrush(BackColor);
            borderPen = new Pen(BorderColor);
        }

        public bool Contains(Vector2D position)
        {
            return Contains(position.X, position.Y);
        }

        public bool Contains(int x, int y)
        {
            return (x >= Position.X - 8) && (y >= Position.Y - 8) && (x <= Position.X + 8) && (y <= Position.Y + 8);
        }

        public bool Contains(System.Drawing.Point point)
        {
            return Contains(point.X, point.Y);
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(backBrush, Position.X, Position.Y, Size.Width, Size.Height);
            g.DrawRectangle(borderPen, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}
