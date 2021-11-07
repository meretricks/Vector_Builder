using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Builder.Pages.Components
{
    public interface COModel
    {
        bool Over { get; set; }
        bool Selected { get; set; }
        Vector2D Position { get; set; }
        System.Drawing.Size Size { get; set; }
        void Draw(System.Drawing.Graphics g);
        bool Contains(Vector2D position);
        bool Contains(int x, int y);
    }
}
