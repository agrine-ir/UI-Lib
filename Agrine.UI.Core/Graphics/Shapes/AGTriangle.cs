using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public class AGTriangle : ShapeBase
    {
        public AGTriangle(Point location, Size size)
           : base(location, size) { }

        public override void Draw(System.Drawing.Graphics g)
        {
            Point p1 = new Point(Location.X + Size.Width / 2, Location.Y);
            Point p2 = new Point(Location.X, Location.Y + Size.Height);
            Point p3 = new Point(Location.X + Size.Width, Location.Y + Size.Height);

            Point[] points = { p1, p2, p3 };
            using (LinearGradientBrush brush = new LinearGradientBrush(
                       new Rectangle(Location, Size), FillColor1, FillColor2, GradientMode))
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }
        }

        public override bool Contains(Point p)
        {
            Point p1 = new Point(Location.X + Size.Width / 2, Location.Y);
            Point p2 = new Point(Location.X, Location.Y + Size.Height);
            Point p3 = new Point(Location.X + Size.Width, Location.Y + Size.Height);
            Point[] pts = { p1, p2, p3 };

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(pts);
                return path.IsVisible(p);
            }
        }
    }
}
