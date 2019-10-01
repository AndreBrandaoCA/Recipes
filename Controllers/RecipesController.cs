using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Recipes.Controllers
{
    public class RecipesController:Controller
    {
        public ViewResult Home()
        {
            return View();
        }
        public ViewResult AddRecipe()
        {
            return View();
        }
        public ViewResult RecipeList()
        {
            return View();
        }
        public ViewResult ReviewRecipe()
        {
            return View();
        }
        public ViewResult ViewRecipe()
        {
            return View();
        }

    }
}
