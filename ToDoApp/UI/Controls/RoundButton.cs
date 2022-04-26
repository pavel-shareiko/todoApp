using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NLog;
using ToDoApp.Forms;

namespace ToDoApp.UI.Controls
{
    public sealed class RoundButton : Button, ILoggable
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private int _borderSize = 0;
        private int _borderRadius = 40;
        private Color _borderColor = Color.PaleVioletRed;

        [Category("Logging")] public bool LogEnabled { get; set; } = true;

        [Category("Round Button Settings")]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                value = MathExtension.Clamp(0, value);

                Log(LogLevel.Debug, $"Border size updated. Prev={BorderSize}, New={value}");
                _borderSize = value;
                Invalidate();
            }
        }

        [Category("Round Button Settings")]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                value = MathExtension.Clamp(0, value, 90);

                Log(LogLevel.Debug, $"Border radius updated. Prev={BorderRadius}, New={value}");
                _borderRadius = value;
                Invalidate();
            }
        }

        [Category("Round Button Settings")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                Log(LogLevel.Debug, $"Border color updated. Prev={BorderColor}, New={value}");
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Round Button Settings")]
        public Color BackGroundColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        [Category("Round Button Settings")]
        public Color TextColor
        {
            get => ForeColor;
            set => ForeColor = value;
        }

        public RoundButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            var path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            var rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (BorderRadius > 2)
            {
                using (var pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (var pathBorder = GetFigurePath(rectBorder, BorderRadius - 1f))
                using (var penSurface = new Pen(this.Parent.BackColor, 2))
                using (var penBorder = new Pen(BorderColor, BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(pathSurface);

                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (BorderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                Region = new Region(rectSurface);
                if (BorderSize >= 1)
                {
                    using (var penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += Container_BackColorChanged;
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void Log(LogLevel level, string message)
        {
            if (LogEnabled)
            {
                Logger.Log(level, message);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            Log(LogLevel.Debug, $"OnMouseClick(): {this.Name} clicked");
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Log(LogLevel.Debug, $"OnClick(): {this.Name} clicked");
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}