namespace Vector.Builder.Pages.Components
{
    internal class Vector2Dcom : COModel
    {
        public System.Drawing.Size Size { get; set; } = System.Drawing.Size.Empty;
        public Vector2D Position { get; set; }
        public bool Selected { get; set; } = false;
        public bool Over { get; set; }
        public System.Drawing.Rectangle Bounds = new System.Drawing.Rectangle();

        public Vector2Dcom(int x, int y)
        {
            Position = new Vector2D(x, y);
            Over = false;
            Bounds = new System.Drawing.Rectangle(Position.X - 8, Position.Y - 8, 16, 16);
        }

        public void Draw(System.Drawing.Graphics g)
        {
            if (!Over & !Selected)
                g.DrawImage(Properties.Resources.Vector2DMarker, Bounds);
            else
                g.DrawImage(Selected ? Properties.Resources.Vector2DMarker_Over_Selected : Properties.Resources.Vector2DMarker_Over, new System.Drawing.Rectangle(Position.X - 11, Position.Y - 11, 22, 22));
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
    }
}