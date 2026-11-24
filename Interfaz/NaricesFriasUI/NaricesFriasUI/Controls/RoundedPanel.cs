using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NaricesFriasUI.Controls
{
    public class RoundedPanel : Panel
    {
        private int _borderRadius = 12;
        private Color _borderColor = Color.FromArgb(203, 213, 225);
        private Color _accentLeftColor = Color.Transparent;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color AccentLeftColor
        {
            get => _accentLeftColor;
            set { _accentLeftColor = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            if (Parent != null)
            {
                using var parentBrush = new SolidBrush(Parent.BackColor);
                e.Graphics.FillRectangle(parentBrush, ClientRectangle);
            }

            using var path = GetRoundedPath(rect, _borderRadius);
            using var fillBrush = new SolidBrush(BackColor);
            e.Graphics.FillPath(fillBrush, path);

            if (_accentLeftColor != Color.Transparent)
            {
                e.Graphics.SetClip(path);
                using var accentBrush = new SolidBrush(_accentLeftColor);
                e.Graphics.FillRectangle(accentBrush, 0, 0, 6, Height);
                e.Graphics.ResetClip();
            }

            using var borderPen = new Pen(_borderColor, 1f);
            e.Graphics.DrawPath(borderPen, path);
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            if (d <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
