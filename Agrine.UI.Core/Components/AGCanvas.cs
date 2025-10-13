using Agrine.UI.Core.Graphics.Shapes;
using System;
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
        private ShapeAlignments _alignment = ShapeAlignments.Center;

        private Size _shapeSize = new Size(150, 100);

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

        [Category("AGCanvas")]
        [Description("Specifies the alignment of the shape inside the canvas.")]
        public ShapeAlignments ShapeAlignment
        {
            get { return _alignment; }
            set
            {
                _alignment = value;
                UpdateShapePosition();
                Invalidate();
            }
        }

        [Category("AGCanvas")]
        [Description("Defines the size of the shape when ShapeAlignment is not Stretch.")]
        public Size ShapeSize
        {
            get { return _shapeSize; }
            set
            {
                _shapeSize = value;
                UpdateShapePosition();
                Invalidate();
            }
        }

        [Category("AGCanvas")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Current shape properties.")]
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
            Size size = _shapeSize;

            switch (_selectedShape)
            {
                case ShapeTypes.Rectangle:
                    _shape = new AGRectangle(loc, size);
                    break;
                case ShapeTypes.Circle:
                    _shape = new AGCircle(loc, new Size(size.Width, size.Width));
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
                    _shape = new AGStar(loc, size);
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

            UpdateShapePosition();
        }

        private void UpdateShapePosition()
        {
            if (_shape == null)
                return;

            Size canvasSize = this.ClientSize;
            Size shapeSize = (_alignment == ShapeAlignments.Stretch)
                ? canvasSize
                : _shapeSize;

            Point loc = new Point(0, 0);

            switch (_alignment)
            {
                case ShapeAlignments.Center:
                    loc = new Point(
                        (canvasSize.Width - shapeSize.Width) / 2,
                        (canvasSize.Height - shapeSize.Height) / 2);
                    break;
                case ShapeAlignments.Left:
                    loc = new Point(0, (canvasSize.Height - shapeSize.Height) / 2);
                    break;
                case ShapeAlignments.Right:
                    loc = new Point(canvasSize.Width - shapeSize.Width, (canvasSize.Height - shapeSize.Height) / 2);
                    break;
                case ShapeAlignments.Top:
                    loc = new Point((canvasSize.Width - shapeSize.Width) / 2, 0);
                    break;
                case ShapeAlignments.Bottom:
                    loc = new Point((canvasSize.Width - shapeSize.Width) / 2, canvasSize.Height - shapeSize.Height);
                    break;
                case ShapeAlignments.Stretch:
                    loc = new Point(0, 0);
                    break;
                case ShapeAlignments.None:
                    // Keep current shape position
                    loc = _shape.Location;
                    break;
            }

            _shape.Location = loc;
            _shape.Size = shapeSize;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateShapePosition();
            Invalidate();
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
