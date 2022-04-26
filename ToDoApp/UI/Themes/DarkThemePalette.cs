using System.Drawing;

namespace ToDoApp.UI.Themes
{
    public class DarkThemePalette : IColorPalette
    {
        public Color GetAccentColor()
        {
            return Color.FromArgb(31, 29, 54);
        }

        public Color GetSecondaryColor()
        {
            return Color.FromArgb(63, 51, 81);
        }

        public Color GetThirdColor()
        {
            return Color.FromArgb(134, 72, 121);
        }

        public Color GetBackgroundColor()
        {
            return Color.FromArgb(233, 166, 166);
        }
    }
}