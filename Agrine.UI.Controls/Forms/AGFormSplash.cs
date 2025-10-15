using Agrine.UI.Core.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Agrine.UI.Controls.Forms
{

    public partial class AGFormSplash : AGForm
    {

        private Timer animationTimer;
        private double opacityIncrement = 0.05;
        private int slideDistance = 20;
        private Point targetLocation;


        public AGFormSplash()
        {
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.FormBorderStyle = FormBorderStyle.None;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Size = new Size(400, 300);
            this.Opacity = 0; 

            animationTimer = new Timer();
            animationTimer.Interval = 15;
            animationTimer.Tick += AnimationTimer_Tick;

            targetLocation = this.Location;
            this.Location = new Point(targetLocation.X, targetLocation.Y - slideDistance);
        }


        [Category("Animation")]
        public bool EnableAnimation { get; set; } = true;


        [Category("Border")]
        public byte BorderRadius { get; set; } = 5;

        [Category("Border")]
        public byte BorderSize { get; set; } = 3;

        [Category("Border")]
        public Color BorderColor { get; set; } = Color.Black;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            targetLocation = this.Location;

            if (!this.DesignMode && this.EnableAnimation)
            {
                this.Opacity = 0;
                this.Location = new Point(targetLocation.X, targetLocation.Y - slideDistance);
                animationTimer.Start();
            }
            else
            {
                this.Opacity = 1;
                this.Location = targetLocation;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;



            RectangleF rect = new RectangleF(0.5f, 0.5f, this.Width - 1f, this.Height - 1f);

            using (GraphicsPath path = AGRadius.GetRoundPath(rect, this.BorderRadius))
            {
                this.Region = new Region(path);

                using (Pen pen = new Pen(this.BorderColor, this.BorderSize))
                {
                    pen.Alignment = PenAlignment.Center;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Fade-in
            if (this.Opacity < 1)
                this.Opacity += opacityIncrement;
            else
                this.Opacity = 1;

            // Slide-in
            if (this.Location.Y < targetLocation.Y)
            {
                int newY = this.Location.Y + 2; 
                if (newY > targetLocation.Y) newY = targetLocation.Y;
                this.Location = new Point(this.Location.X, newY);
            }

            if (this.Opacity >= 1 && this.Location.Y >= targetLocation.Y)
                animationTimer.Stop();
        }




    }



}
