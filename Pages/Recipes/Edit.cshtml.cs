using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProj.Models;

namespace Final_Saria159.Pages_Recipes
{
    public class EditModel : PageModel
    {
        private readonly FinalProj.Models.AppDbContext _context;

        public EditModel(FinalProj.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recipe Recipe { get; set; } = default!;

        public List<Ingredient> Ingredients {get; set;} = default!; 


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe =  await _context.Recipes.Include(s => s.RecipeIngredients!).ThenInclude(sc => sc.Recipe).FirstOrDefaultAsync(m => m.RecipeID == id);
            Ingredients = _context.Ingredients.ToList();

            var recipes =  await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeID == id);
            if (recipe == null)
            {
                return NotFound();
            }
            Recipe = recipe;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int[] selectedIngredients)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var recipeToUpdate = await _context.Recipes.Include(s => s.RecipeIngredients!).ThenInclude(sc => sc.Ingredient).FirstOrDefaultAsync(m => m.RecipeID == Recipe.RecipeID);
            if (recipeToUpdate != null)
            {
                recipeToUpdate.RecipeName = Recipe.RecipeName;
                recipeToUpdate.RecipeDesc = Recipe.RecipeDesc;
                UpdateRecipeIngredients(selectedIngredients, recipeToUpdate);
            }
            //_context.Attach(Recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(Recipe.RecipeID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.RecipeID == id);
        }

    private void UpdateRecipeIngredients(int[] selectedIngredients, Recipe recipeToUpdate)
    {
        if (selectedIngredients == null)
        {
            recipeToUpdate.RecipeIngredients = new List<RecipeIngredient>();
            return;
        }

        List<int> currentIngredients = recipeToUpdate.RecipeIngredients!.Select(c => c.IngredientID).ToList();
        List<int> selectedIngredientsList = selectedIngredients.ToList();

        foreach (var ingredients in _context.Ingredients)
        {
            if (selectedIngredientsList.Contains(ingredients.IngredientID))
            {
                if (!currentIngredients.Contains(ingredients.IngredientID))
                {
                    recipeToUpdate.RecipeIngredients!.Add(
                        new RecipeIngredient { RecipeID = recipeToUpdate.RecipeID, IngredientID = ingredients.IngredientID }
                    );
                }
            }
            else
            {
                if (currentIngredients.Contains(ingredients.IngredientID))
                {
                    RecipeIngredient ingredientToRemove = recipeToUpdate.RecipeIngredients!.SingleOrDefault(s => s.RecipeID == Recipe.RecipeID)!;
                    _context.Remove(ingredientToRemove);
                    
                }
            }
        }
    }
}
}



