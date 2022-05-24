using System.Drawing;
using System.Windows.Forms;

namespace ToDoApp.Extensions
{
    public static class ColorExtension
    {
        public static Color GetContrastColor(this Color color)
        {
            var luma = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;

            return luma > 0.60 ? Color.Black : Color.White;
        }

        public static Color Lighten(this Color color, float perc = 0.5F)
        {
            return ControlPaint.Light(color, perc);
        }

        public static Color Darken(this Color color, float perc = 0.5F)
        {
            return ControlPaint.Dark(color, perc);
        }

        public static bool IsBright(this Color color)
        {
            return color.GetBrightness() >= 0.5;
        }
    }
}