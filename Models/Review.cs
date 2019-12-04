using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int RecipeId { get; set; }
        public int Rating { get; set; }
        public String Description { get; set; }
    }
}
