using System.Drawing;

namespace ToDoApp.UI.Themes
{
    public class DarkThemePalette : IColorPalette
    {
        public Color GetAccentColor()
        {
            return Color.FromArgb(204, 0, 0);
        }

        public Color GetSecondaryColor()
        {
            return Color.FromArgb(63, 51, 81);
        }

        public Color GetThirdColor()
        {
            return Color.FromArgb(30, 30, 30);
        }

        public Color GetBackgroundColor()
        {
            return Color.FromArgb(18, 18, 18);
        }
    }
}