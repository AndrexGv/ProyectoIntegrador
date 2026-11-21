using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NaricesFriasUI.Controls
{
    public class PawLogoControl : Control
    {
        private Color _circleColor = Color.FromArgb(234, 88, 12);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color CircleColor
        {
            get => _circleColor;
            set { _circleColor = value; Invalidate(); }
        }

        public PawLogoControl()
        {
            DoubleBuffered = true;
            Size = new Size(48, 48);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using var bgBrush = new SolidBrush(_circleColor);
            e.Graphics.FillEllipse(bgBrush, 1, 1, Width - 3, Height - 3);

            float w = Width;
            float h = Height;
            using var pawBrush = new SolidBrush(Color.White);

            // Almohadilla central
            e.Graphics.FillEllipse(pawBrush, w * 0.30f, h * 0.48f, w * 0.40f, h * 0.30f);

            // Dedos
            e.Graphics.FillEllipse(pawBrush, w * 0.21f, h * 0.32f, w * 0.14f, h * 0.18f);
            e.Graphics.FillEllipse(pawBrush, w * 0.36f, h * 0.22f, w * 0.13f, h * 0.18f);
            e.Graphics.FillEllipse(pawBrush, w * 0.51f, h * 0.22f, w * 0.13f, h * 0.18f);
            e.Graphics.FillEllipse(pawBrush, w * 0.65f, h * 0.32f, w * 0.14f, h * 0.18f);
        }
    }
}
