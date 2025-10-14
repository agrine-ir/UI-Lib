using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Agrine.UI.Controls.Forms
{

    public partial class AGFormSplash : AGForm
    {


        public AGFormSplash()
        {
            this.AutoScaleMode = AutoScaleMode.Inherit;
        }



        public byte BorderRadius { get; set; } = 5;

        public byte BorderSize { get; set; } = 3;

        public Color BorderColor { get; set; } = Color.Tomato;



    }



}
