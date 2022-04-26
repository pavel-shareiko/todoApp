using System.Drawing;

namespace ToDoApp.UI.Themes
{
    public class LightThemePalette : IColorPalette
    {
        public Color GetAccentColor()
        {
            return rgb(73, 84, 100);
        }

        public Color GetSecondaryColor()
        {
            return rgb(187, 191, 202);
        }
        
        public Color GetThirdColor()
        {
            return rgb(232, 232, 232);
        }

        public Color GetBackgroundColor()
        {
            return rgb(244, 244, 242);
        }

        private Color rgb(byte red, byte green, byte blue)
        {
            return Color.FromArgb(red, green, blue);
        }
    }
}