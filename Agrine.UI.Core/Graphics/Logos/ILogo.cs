using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrine.UI.Core.Graphics.Logos
{
    public interface ILogo
    {
        Point Location { get; set; }
        Size Size { get; set; }

        void Draw(System.Drawing.Graphics g);
        bool Contains(Point p);
        void Move(int dx, int dy);
        void Resize(Size newSize);


    }
}
