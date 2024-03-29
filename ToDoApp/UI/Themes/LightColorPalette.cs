﻿using System.Drawing;

namespace ToDoApp.UI.Themes
{
    public class LightColorPalette : IColorPalette
    {
        public Color GetAccentColor()
        {
            return rgb(31, 29, 54);
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

        public Color GetHighlightColor()
        {
            return Color.FromArgb(20, 125, 249, 255);
        }

        private Color rgb(byte red, byte green, byte blue)
        {
            return Color.FromArgb(red, green, blue);
        }
    }
}