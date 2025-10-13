using System.Drawing;
using System.Drawing.Drawing2D;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public class AGRectangle : ShapeBase
    {
        public AGRectangle(Point location, Size size)
           : base(location, size) { }

        public override void Draw(System.Drawing.Graphics g)
        {
            Rectangle rect = new Rectangle(Location, Size);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, FillColor1, FillColor2, GradientMode))
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            using (GraphicsPath path = GetRoundedRect(rect, CornerRadius))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }
        }

        public override bool Contains(Point p)
        {
            Rectangle rect = new Rectangle(Location, Size);
            using (GraphicsPath path = GetRoundedRect(rect, CornerRadius))
            {
                return path.IsVisible(p);
            }
        }
    }
}
