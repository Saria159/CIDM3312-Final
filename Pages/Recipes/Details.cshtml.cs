using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProj.Models;

namespace Final_Saria159.Pages_Recipes
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProj.Models.AppDbContext _context;

        public DetailsModel(FinalProj.Models.AppDbContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeID == id);

            if (recipe is not null)
            {
                Recipe = recipe;

                return Page();
            }

            return NotFound();
        }
    }
}
