using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Notification
{
    public class ButtonCustom : Button
    {
        private int boderSize = 0;
        private int boderRadius = 40;
        private Color BorderColor = Color.AntiqueWhite;


        public ButtonCustom() 
        {

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.Aquamarine;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect,float radius) 
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF RectangleSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF RectangleBorder = new RectangleF(1,1,this.Width-0.8F,this.Height-1);

            if(boderRadius > 2)
            {
                using(GraphicsPath pathSurface = GetFigurePath(RectangleSurface,boderRadius))
                using(GraphicsPath pathBorder=GetFigurePath(RectangleBorder,boderRadius-1F))
                using(Pen Pensurface = new Pen(this.Parent.BackColor,2))
                using (Pen penBorder = new Pen(BorderColor, boderSize)) 
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(Pensurface, pathSurface);
                    if(boderSize >= 1) 
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(RectangleSurface);
                if(boderSize >= 1) 
                {
                    using(Pen penBorder=new Pen(BorderColor, boderSize)) 
                    {
                        penBorder.Alignment= PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder,0,0,this.Width-1,this.Height-1);
                    }
                }
            }
            
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) 
            {
                this.Invalidate();

            }
        }
    }
}
