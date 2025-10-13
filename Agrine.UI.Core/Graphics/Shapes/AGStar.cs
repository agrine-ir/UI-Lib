using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public class AGStar : ShapeBase
    {
        public int Points { get; set; } = 5;

        public AGStar(Point location, Size size)
            : base(location, size) { }

        public override void Draw(System.Drawing.Graphics g)
        {
            PointF[] pts = CreateStarPoints(Location, Size, Points);

            using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(Location, Size), FillColor1, FillColor2, GradientMode))
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPolygon(brush, pts);
                g.DrawPolygon(pen, pts);
            }
        }

        public override bool Contains(Point p)
        {
            PointF[] pts = CreateStarPoints(Location, Size, Points);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(pts);
                return path.IsVisible(p);
            }
        }

        private PointF[] CreateStarPoints(Point location, Size size, int points)
        {
            var list = new System.Collections.Generic.List<PointF>();
            double rx = size.Width / 2.0;
            double ry = size.Height / 2.0;
            double cx = location.X + rx;
            double cy = location.Y + ry;
            double step = Math.PI / points;

            for (int i = 0; i < points * 2; i++)
            {
                double r = (i % 2 == 0) ? rx : rx / 2.5;
                double angle = i * step - Math.PI / 2;
                list.Add(new PointF((float)(cx + r * Math.Cos(angle)), (float)(cy + ry * Math.Sin(angle))));
            }
            return list.ToArray();
        }
    }
}
