using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class PrintFile : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}