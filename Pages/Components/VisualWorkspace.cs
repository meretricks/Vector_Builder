using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vector.Builder.Tools;

namespace Vector.Builder.Pages.Components
{
    public partial class VisualWorkspace : UserControl
    {
        public enum Tools
        {
            Vector_Pointer,
            Vector_Line,
            Vector_Square,
            Selector,
            Link,
            None
        }

        public Tools SelectedTool = Tools.None;

        //Ruler/Grid Colors
        public Color RulerBackColor = Color.WhiteSmoke;
        public Color RulerLineColor = Color.LightGray;
        public Color CrossHairColor = Color.DarkGray;

        public SolidBrush RulerBackBrush { get; set; }
        public Pen RulerLinePen { get; set; }
        public Pen CrossHairPen { get; set; }

        bool DrawCrossHairs = true;
        bool DrawRulerPointers = true;
        bool DrawGrid = true;

        bool MouseOver = false;

        public List<COModel> Models { get; } = new List<COModel>();

        Point MouseLocation = Point.Empty;
        Rectangle ViewBounds;

        Vector2D MouseGridSnap = Vector2D.Empty;

        public VisualWorkspace()
        {
            RulerBackBrush = new SolidBrush(RulerBackColor);
            RulerLinePen = new Pen(RulerLineColor);
            CrossHairPen = new Pen(CrossHairColor);

            InitializeComponent();
            ViewBounds = new Rectangle(22, 22, Width, Height);
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ViewBounds = new Rectangle(22, 22, Width, Height);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseOver = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseOver = false;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            MouseLocation = e.Location;
            MouseGridSnap = new Vector2D(e.X - (e.X % 10)+2, e.Y - (e.Y % 10)+2);

            try
            {
                Models.Where(c => c.Over).ToList().ForEach(e => e.Over = false);
                Models.Where(c => c.Contains(e.X, e.Y)).ToList().Last().Over = true;
            }
            catch (Exception ex) { }
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {

            switch (SelectedTool)
            {
                case Tools.Vector_Pointer:
                    break;

                case Tools.Vector_Line:
                    break;

                case Tools.Vector_Square:
                    break;
                case Tools.Selector:
                    break;
                case Tools.Link:
                    break;
                default:
                    break;
            }

            switch (e.Button)
            {
                case MouseButtons.Right:
                    try {
                        Models.Remove(Models.Where(c => c.Contains(e.X, e.Y)).Last()); } //removes only the top-most element. 
                    catch (Exception ex) { }
                    break;
                case MouseButtons.Left:
                    if (!ViewBounds.Contains(e.Location))
                        return;

                    var o = new Vector2Dcom(MouseGridSnap.X, MouseGridSnap.Y); //e.x, e.y//
                    var queue = Models.Where(c => c.Position.Compare(o.Position));
                    if (queue.Count() == 0)
                    { Models.Add(o); }
                    else
                    { 
                        queue.Last().Selected = ! queue.Last().Selected;
                        foreach (var m in Models.Where(c => c != queue.Last()))
                            m.Selected = false;
                    }
                    break;
                default:
                    return;
            }
        }

        /*protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }*/

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawRuler(e.Graphics);
            //DrawVectorLines(e.Graphics);

            if (MouseOver && DrawCrossHairs && ViewBounds.Contains(MouseGridSnap.ToPoint()))
            {
                e.Graphics.DrawLine(CrossHairPen, new Point(MouseGridSnap.X, 0), new Point(MouseGridSnap.X, Height));
                e.Graphics.DrawLine(CrossHairPen, new Point(0, MouseGridSnap.Y), new Point(Width, MouseGridSnap.Y));
            }

            foreach (var model in Models)
                model.Draw(e.Graphics);
        }

        void DrawRuler(Graphics g)
        {
            var r1 = new Rectangle(0, 0, Width, 22);
            var r2 = new Rectangle(0, 0, 22, Height);

            var r3 = new Rectangle(0, 0, 22, 22);

            g.FillRectangle(RulerBackBrush, r1);
            g.FillRectangle(RulerBackBrush, r2);
            g.DrawLine(RulerLinePen, 0, 22, Width, 22);
            g.DrawLine(RulerLinePen, 22, 0, 22, Height);



            for (int i = 0; i < Width - 22 / 100; i++)
                g.DrawLine(RulerLinePen, 22 + (i * 100), 0, 22 + (i * 100), 22);
            for (int i = 0; i < Height - 22 / 100; i++)
                g.DrawLine(RulerLinePen, 0, 22 + (i * 100), 22, 22 + (i * 100));

            for (int i = 0; i < Width / 10; i++)
                g.DrawLine(RulerLinePen, 22 + (i * 10), 11, 22 + (i * 10), DrawGrid ? Height : 22);
            for (int i = 0; i < Height / 10; i++)
                g.DrawLine(RulerLinePen, 11, 22 + (i * 10), DrawGrid ? Width : 22, 22 + (i * 10));

            if (MouseOver && DrawRulerPointers)
            {
                var x = Math.Max(22, MouseLocation.X);
                var y = Math.Max(22, MouseLocation.Y);
                g.DrawImage(Properties.Resources.Ruler_Point_Top, new Rectangle((x - (x % 10)+2), 0, 22, 22));
                g.DrawImage(Properties.Resources.Ruler_Point_Left, new Rectangle(0, (y - (y % 10)+2), 22, 22));
            }
        }

        void DrawVectorLines(Graphics g)
        {
            if (Models.Count <= 1)
                return;

            for (int i = 0; i < Models.Count -1; i++)
            {
                var o = Models[i+1];
                g.DrawLine(new Pen(Color.FromArgb(150, Color.Red)), Models[i].Position.ToPoint(), o.Position.ToPoint());
            }
        }

    }
}