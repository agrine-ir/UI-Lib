using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public abstract class ShapeBase : IShape
    {
        public Point Location { get; set; }
        public Size Size { get; set; }

        public Color FillColor1 { get; set; } = Color.LightGray;
        public Color FillColor2 { get; set; } = Color.White;
        public LinearGradientMode GradientMode { get; set; } = LinearGradientMode.Vertical;

        public Color BorderColor { get; set; } = Color.Black;
        public float BorderThickness { get; set; } = 2f;
        public float CornerRadius { get; set; } = 0f;

        protected ShapeBase(Point location, Size size)
        {
            Location = location;
            Size = size;
        }

        public abstract void Draw(Graphics g);
        public abstract bool Contains(Point p);

        public virtual void Move(int dx, int dy)
        {
            Location = new Point(Location.X + dx, Location.Y + dy);
        }

        public virtual void Resize(Size newSize)
        {
            Size = newSize;
        }


        protected GraphicsPath GetRoundedRect(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            float d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
