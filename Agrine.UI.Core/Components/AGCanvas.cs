using Agrine.UI.Core.Graphics.Shapes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace YourProject.Graphics
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
                UpdateCanvasCorners();
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
                UpdateCanvasCorners();
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
                UpdateCanvasCorners();
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
            UpdateCanvasCorners();
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
                    loc = _shape.Location;
                    break;
            }

            _shape.Location = loc;
            _shape.Size = shapeSize;
        }

        /// <summary>
        /// Applies rounded corners to AGCanvas 
        /// only if the shape is Rectangle, alignment is Stretch, and CornerRadius > 0.
        /// </summary>
        private void UpdateCanvasCorners()
        {
            if (_shape == null)
            {
                this.Region = null;
                return;
            }

            bool isRectangle = _selectedShape == ShapeTypes.Rectangle;
            bool isStretch = _alignment == ShapeAlignments.Stretch;
            bool hasRadius = _shape.CornerRadius > 0;

            if (isRectangle && isStretch && hasRadius)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    float radius = _shape.CornerRadius;
                    Rectangle rect = this.ClientRectangle;

                    float d = radius * 2;
                    path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                    path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                    path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                    path.CloseFigure();

                    this.Region = new Region(path);
                }
            }
            else
            {
                this.Region = null; // revert to normal rectangular canvas
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateShapePosition();
            UpdateCanvasCorners();
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
                UpdateCanvasCorners(); // keep corners synced with shape radius
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
