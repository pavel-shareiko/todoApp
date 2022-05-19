using System.Drawing;

namespace ToDoApp.UI.Themes
{
    public interface IColorPalette
    {
        Color GetAccentColor();
        Color GetSecondaryColor();
        Color GetThirdColor();
        Color GetBackgroundColor();
        Color GetHighlightColor();
    }

}