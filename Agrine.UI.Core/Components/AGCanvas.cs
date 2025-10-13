using Agrine.UI.Core.Graphics.Shapes;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Agrine.UI.Core.Components
{
    public class AGCanvas : Control
    {
        private IShape _shape;
        private ShapeTypes _selectedShape = ShapeTypes.None;

        [Category("AGCanvas")]
        [Description("Specifies which shape should be drawn.")]
        public ShapeTypes SelectedShape
        {
            get { return _selectedShape; }
            set
            {
                _selectedShape = value;
                CreateShape();
                Invalidate();
            }
        }

        [Browsable(false)]
        public IShape Shape
        {
            get { return _shape; }
        }

        public AGCanvas()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
        }

        private void CreateShape()
        {
            Point loc = new Point(60, 60);
            Size size = new Size(150, 100);

            switch (_selectedShape)
            {
                case ShapeTypes.Rectangle:
                    _shape = new AGRectangle(loc, size);
                    break;
                case ShapeTypes.Circle:
                    _shape = new AGCircle(loc, new Size(100, 100));
                    break;
                case ShapeTypes.Ellipse:
                    _shape = new AGEllipse(loc, size);
                    break;
                case ShapeTypes.Triangle:
                    _shape = new AGTriangle(loc, size);
                    break;
                case ShapeTypes.Diamond:
                    _shape = new AGDiamond(loc, size);
                    break;
                case ShapeTypes.Star:
                    _shape = new AGStar(loc, new Size(120, 120));
                    break;
                default:
                    _shape = null;
                    break;
            }

            if (_shape != null)
            {
                _shape.FillColor1 = Color.SkyBlue;
                _shape.FillColor2 = Color.White;
                _shape.BorderColor = Color.SteelBlue;
                _shape.BorderThickness = 2f;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            System.Drawing.Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (_shape != null)
            {
                _shape.Draw(g);
            }
            else
            {
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString("No shape selected", this.Font, Brushes.Gray, this.ClientRectangle, sf);
                }
            }
        }
    }
}
