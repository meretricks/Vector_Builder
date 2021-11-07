using System.Drawing;

namespace Vector.Builder.Pages.Components
{
    public interface COModel
    {
        public bool Over { get; set; }
        public bool Selected { get; set; }
        public Vector2D Position { get; set; }
        public System.Drawing.Size Size { get; set; }
        public abstract void Draw(Graphics g);
        public bool Contains(Vector2D position);
        public bool Contains(int x, int y);
        public bool Contains(Point point);
    }
}
