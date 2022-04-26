using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ToDoApp.UI.Themes
{
    public class WindowsThemePalette : IColorPalette
    {
        private const float DefaultBrightnessMultiplier = 0.25F;
        
        [DllImport("uxtheme.dll", EntryPoint = "#95")]
        private static extern uint GetImmersiveColorFromColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType,
            bool bIgnoreHighContrast, uint dwHighContrastCacheMode);

        [DllImport("uxtheme.dll", EntryPoint = "#96")]
        private static extern uint GetImmersiveColorTypeFromName(IntPtr pName);

        [DllImport("uxtheme.dll", EntryPoint = "#98")]
        private static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);

        public Color GetAccentColor()
        {
            var userColorSet = GetImmersiveUserColorSetPreference(false, false);
            var colorType =
                GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground"));
            var colorSetEx = GetImmersiveColorFromColorSetEx((uint)userColorSet, colorType, false, 0);

            return ConvertDWordColorToRgb(colorSetEx);
        }

        public Color GetSecondaryColor()
        {
            var primaryColor = GetAccentColor();
            
            return primaryColor.IsBright() 
                ? primaryColor.Darken() 
                : primaryColor.Lighten();
        }

        public Color GetThirdColor()
        {
            var primaryColor = GetAccentColor();
            var secondaryColor = GetSecondaryColor();
            
            return primaryColor.IsBright() 
                ? secondaryColor.Darken(DefaultBrightnessMultiplier) 
                : secondaryColor.Lighten(DefaultBrightnessMultiplier);
        }

        public Color GetBackgroundColor()
        {
            var primaryColor = GetAccentColor();
            var thirdColor = GetThirdColor();
            
            return primaryColor.IsBright() 
                ? thirdColor.Darken(DefaultBrightnessMultiplier) 
                : thirdColor.Lighten(DefaultBrightnessMultiplier + 0.55F);
        }
        
        private static Color ConvertDWordColorToRgb(uint colorSetEx)
        {
            var red = (byte)((0x000000FF & colorSetEx) >> 0);
            var green = (byte)((0x0000FF00 & colorSetEx) >> 8);
            var blue = (byte)((0x00FF0000 & colorSetEx) >> 16);
            var alpha = (byte)((0xFF000000 & colorSetEx) >> 24);

            return Color.FromArgb(alpha, red, green, blue);
        }
    }
}