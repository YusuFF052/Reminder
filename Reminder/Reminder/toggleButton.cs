using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace ToggleButton
{
    public class toggleButton:CheckBox
    {
        private Color onBackColor = Color.FromArgb(0, 169, 165);
        private Color onToggleColor = Color.FromArgb(11, 83, 81);

        public toggleButton()
        {
            this.MinimumSize = new Size(45,22);
        }
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArch = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArch = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure(); path.AddArc(leftArch, 90, 180);
            path.AddArc(rightArch, 270, 180); path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor),GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),new Rectangle(this.Width-this.Height+1,2,toggleSize,toggleSize));

            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
