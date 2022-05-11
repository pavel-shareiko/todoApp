using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ToDoApp.UI.UserControls
{
    public partial class Spinner : UserControl
    {
        #region Constants
        private static readonly int kSpinnerLength = 100;
        #endregion

        #region Fields
        private int increment = 1;
        private int radius = 4;
        private int n = 8;
        private int next = 0;
        private Timer timer = null;
        #endregion

        #region Constructor
        public Spinner()
        {
            this.Size = new Size(100, 100);

            timer = new Timer();
            timer.Tick += (s, e) => this.Invalidate();

            if (!DesignMode)
                timer.Enabled = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
        }
        #endregion

        #region Methods (Protected - Override)
        protected override void OnPaint(PaintEventArgs e)
        {
            if (null != Parent && (this.BackColor.A != 255 || this.BackColor == Color.Transparent))
            {
                using (var bmp = new Bitmap(Parent.Width, Parent.Height))
                {
                    Parent.Controls.Cast<Control>()
                          .Where(c => Parent.Controls.GetChildIndex(c) > Parent.Controls.GetChildIndex(this))
                          .Where(c => c.Bounds.IntersectsWith(this.Bounds))
                          .OrderByDescending(c => Parent.Controls.GetChildIndex(c))
                          .ToList()
                          .ForEach(c => c.DrawToBitmap(bmp, c.Bounds));

                    e.Graphics.DrawImage(bmp, -Left, -Top);

                    if (this.BackColor != Color.Transparent)
                        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(0, 0, Width, Height));
                }
            }

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            int length = kSpinnerLength;
            PointF center = new PointF(Width / 2, Height / 2);
            int bigRadius = length / 2 - radius - (n - 1) * increment;
            float unitAngle = 360 / n;

            if (!DesignMode)
                next++;

            next = next >= n ? 0 : next;
            int a = 0;
            for (int i = next; i < next + n; i++)
            {
                int factor = i % n;
                float c1X = center.X + (float)(bigRadius * Math.Cos(unitAngle * factor * Math.PI / 180));
                float c1Y = center.Y + (float)(bigRadius * Math.Sin(unitAngle * factor * Math.PI / 180));
                int currRad = radius + a * increment;
                PointF c1 = new PointF(c1X - currRad, c1Y - currRad);

                e.Graphics.FillEllipse(Brushes.White, c1.X, c1.Y, 2 * currRad, 2 * currRad);

                using (Pen pen = new Pen(Color.White, 2))
                    e.Graphics.DrawEllipse(pen, c1.X, c1.Y, 2 * currRad, 2 * currRad);

                a++;
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            timer.Enabled = Visible;

            base.OnVisibleChanged(e);
        }
        #endregion
    }
}
