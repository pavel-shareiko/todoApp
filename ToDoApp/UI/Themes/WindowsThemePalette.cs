using System.Drawing;
using System.Runtime.InteropServices;

namespace ToDoApp.UI.Themes
{
    public class WindowsThemePalette : IColorPalette
    {

        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

        private readonly IColorPalette _colorPalette;
        public WindowsThemePalette()
        {
            _colorPalette = GetColorPalette();
        }

        private static IColorPalette GetColorPalette()
        {
            if (ShouldSystemUseDarkMode())
            {
                return new DarkThemePalette();
            }

            return new LightThemePalette();
        }

        public Color GetAccentColor()
        {
            return _colorPalette.GetAccentColor();
        }

        public Color GetSecondaryColor()
        {
            return _colorPalette.GetSecondaryColor();
        }

        public Color GetThirdColor()
        {
            return _colorPalette.GetThirdColor();
        }

        public Color GetBackgroundColor()
        {
            return _colorPalette.GetBackgroundColor();
        }
    }
}