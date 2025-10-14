using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Logos
{
    public enum LogoTypes
    {
        None, Agrine, Calculator, Check
    }

    public enum LogoAlignments
    {
        None,
        Center,
        Left,
        Right,
        Top,
        Bottom,
        Stretch
    }

    public abstract class LogoBase : ILogo
    {
        public Point Location { get; set; }
        public Size Size { get; set; }

        public abstract void Draw(System.Drawing.Graphics g);
        public abstract bool Contains(Point p);

        public virtual void Move(int dx, int dy)
        {
            Location = new Point(Location.X + dx, Location.Y + dy);
        }

        public virtual void Resize(Size newSize)
        {
            Size = newSize;
        }
    }
}
