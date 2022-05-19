using System.Drawing;
using ToDoApp.UI.Themes;

namespace ToDoApp.UI
{
    public static class ApplicationStyle
    {
        public static IColorPalette ApplicationColorPalette { get; private set; }

        public static Color AccentColor { get; private set; }

        public static Color SecondaryColor { get; private set; }

        public static Color ThirdColor { get; private set; }

        public static Color BackgroundColor { get; private set; }
        public static Color HighlightColor { get; private set; }

        public static Color TextColor => BackgroundColor.GetContrastColor();
        public static Font Font => new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);

        static ApplicationStyle()
        {
            Update();
        }

        public static void Update()
        {
            ApplicationColorPalette = ColorPaletteFactory.Instance.GetColorPalette();
            UpdateColors();
        }

        private static void UpdateColors()
        {
            AccentColor = ApplicationColorPalette.GetAccentColor();
            SecondaryColor = ApplicationColorPalette.GetSecondaryColor();
            ThirdColor = ApplicationColorPalette.GetThirdColor();
            BackgroundColor = ApplicationColorPalette.GetBackgroundColor();
            HighlightColor = ApplicationColorPalette.GetHighlightColor();
        }
    }
}