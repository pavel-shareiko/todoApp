using NLog;
using ToDoApp.Properties;

namespace ToDoApp.UI.Themes
{
    public class ColorPaletteFactory
    {
        public static ColorPaletteFactory Instance => new ColorPaletteFactory();
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private ColorPaletteFactory()
        {
        }

        public IColorPalette GetColorPalette()
        {
            var applicationTheme = Settings.Default.Theme;

            switch (applicationTheme)
            {
                case Theme.Windows:
                    Logger.Debug($"{applicationTheme} Theme factory will be applied to the application");
                    return new WindowsThemePalette();
                case Theme.Dark:
                    Logger.Debug($"{applicationTheme} Theme factory will be applied to the application");
                    return new DarkThemePalette();
                case Theme.Light:
                    Logger.Debug($"{applicationTheme} Theme factory will be applied to the application");
                    return new LightThemePalette();
                default:
                    Logger.Warn($"{applicationTheme} is not a valid theme. Applying the default one. Please, fix the configuration file");
                    return new WindowsThemePalette();
            }
        }
    }
}