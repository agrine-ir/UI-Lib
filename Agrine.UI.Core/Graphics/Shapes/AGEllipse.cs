using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public class AGEllipse : ShapeBase
    {
        public AGEllipse(Point location, Size size)
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
            float a = Size.Width / 2f;
            float b = Size.Height / 2f;
            float centerX = Location.X + a;
            float centerY = Location.Y + b;

            float dx = (p.X - centerX) / a;
            float dy = (p.Y - centerY) / b;

            return dx * dx + dy * dy <= 1;
        }
    }
}
