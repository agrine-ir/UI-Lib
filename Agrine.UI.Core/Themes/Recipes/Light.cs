using System;
using System.Drawing;

namespace Agrine.UI.Core.Themes.Recipes
{
    public struct Light : IRecipe
    {
        public Color ButtonBackColor => Color.Black;

        public Color ButtonForeColor => throw new NotImplementedException();
    }
}
