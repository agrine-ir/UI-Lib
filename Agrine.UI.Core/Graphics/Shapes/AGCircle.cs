using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public class AGCircle : ShapeBase
    {
        public AGCircle(Point location, Size size)
            : base(location, size) { }

        public override void Draw(System.Drawing.Graphics g)
        {
            Rectangle rect = new Rectangle(Location, Size);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, FillColor1, FillColor2, GradientMode))
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(brush, rect);
                g.DrawEllipse(pen, rect);
            }
        }

        public override bool Contains(Point p)
        {
            float centerX = Location.X + Size.Width / 2f;
            float centerY = Location.Y + Size.Height / 2f;
            float radius = Size.Width / 2f;

            float dx = p.X - centerX;
            float dy = p.Y - centerY;

            return dx * dx + dy * dy <= radius * radius;
        }
    }
}
