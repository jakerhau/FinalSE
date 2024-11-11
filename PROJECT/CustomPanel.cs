using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PROJECT
{
    internal class CustomPanel : Panel
    {
        //Fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //Constructor
        public CustomPanel()
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(350, 200);

        }


        //Properties
        public int BorderRadius { get => borderRadius; set { borderRadius = value; Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; Invalidate(); } }
        public Color GradientTopColor { get => gradientTopColor; set { gradientTopColor = value; Invalidate(); } }
        public Color GradientBottomColor { get => gradientBottomColor; set { gradientBottomColor = value; Invalidate(); } }

        //Methods
        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        //Overridden Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, GradientTopColor, GradientBottomColor, gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, Width, Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetArtanPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {
                    Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else Region = new Region(rectangleF);





        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Kích thước panel thay đổi, vẽ lại
            Invalidate();
        }
    }
}
