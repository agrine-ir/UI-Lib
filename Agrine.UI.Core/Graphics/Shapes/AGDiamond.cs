using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public class AGDiamond : ShapeBase
    {
        public AGDiamond(Point location, Size size)
           : base(location, size) { }

        public override void Draw(System.Drawing.Graphics g)
        {
            Point p1 = new Point(Location.X + Size.Width / 2, Location.Y);
            Point p2 = new Point(Location.X, Location.Y + Size.Height / 2);
            Point p3 = new Point(Location.X + Size.Width / 2, Location.Y + Size.Height);
            Point p4 = new Point(Location.X + Size.Width, Location.Y + Size.Height / 2);

            Point[] pts = { p1, p2, p3, p4 };
            using (LinearGradientBrush brush = new LinearGradientBrush(
                       new Rectangle(Location, Size), FillColor1, FillColor2, GradientMode))
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPolygon(brush, pts);
                g.DrawPolygon(pen, pts);
            }
        }

        public override bool Contains(Point p)
        {
            Point p1 = new Point(Location.X + Size.Width / 2, Location.Y);
            Point p2 = new Point(Location.X, Location.Y + Size.Height / 2);
            Point p3 = new Point(Location.X + Size.Width / 2, Location.Y + Size.Height);
            Point p4 = new Point(Location.X + Size.Width, Location.Y + Size.Height / 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(new[] { p1, p2, p3, p4 });
                return path.IsVisible(p);
            }
        }
    }
}
