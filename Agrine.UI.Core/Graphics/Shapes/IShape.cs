using System.Drawing;
using System.Drawing.Drawing2D;

namespace Agrine.UI.Core.Graphics.Shapes
{
    public interface IShape
    {
        Point Location { get; set; }
        Size Size { get; set; }

        Color FillColor1 { get; set; }
        Color FillColor2 { get; set; }
        LinearGradientMode GradientMode { get; set; }

        Color BorderColor { get; set; }
        float BorderThickness { get; set; }
        float CornerRadius { get; set; }

        void Draw(System.Drawing.Graphics g);
        bool Contains(Point p);
        void Move(int dx, int dy);
        void Resize(Size newSize);
    }
}
