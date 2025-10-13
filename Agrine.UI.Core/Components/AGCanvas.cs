using Agrine.UI.Core.Graphics.Shapes;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Agrine.UI.Core.Components
{
    internal class AGCanvas : System.Windows.Forms.Control
    {

        private readonly List<IShape> _shapes = new List<IShape>();

        public AGCanvas()
        {
            DoubleBuffered = true; 

            _shapes.Add(new AGRectangle(new Point(50, 50), new Size(120, 90))
            {
                FillColor1 = Color.CadetBlue,
                FillColor2 = Color.LightCyan,
                BorderColor = Color.DarkSlateGray,
                BorderThickness = 3f,
                CornerRadius = 20f
            });

            _shapes.Add(new AGCircle(new Point(220, 70), new Size(100, 100))
            {
                FillColor1 = Color.Orange,
                FillColor2 = Color.Yellow,
                BorderColor = Color.Red,
                BorderThickness = 4f
            });
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var shape in _shapes)
                shape.Draw(e.Graphics);
        }
    }
}
