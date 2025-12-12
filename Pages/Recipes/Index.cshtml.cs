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
    public class IndexModel : PageModel
    {
        private readonly FinalProj.Models.AppDbContext _context;

        public IndexModel(FinalProj.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            
            TotalPages = (int)Math.Ceiling(_context.Recipes.Count() / (double)PageSize);
    
            Recipe = await _context.Recipes.Include(s => s.RecipeIngredients!).ThenInclude(sc => sc.Ingredient)
            .Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); 
            var query = _context.Recipes.Include(s => s.RecipeIngredients!).ThenInclude(sc => sc.Ingredient).Select(s => s);
            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(s => s.RecipeName.ToUpper().Contains(CurrentSearch.ToUpper()) || s.RecipeDesc.ToUpper().Contains(CurrentSearch.ToUpper()));
            }

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(s => s.RecipeName);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(s => s.RecipeName);
                    break;
            }

            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);

            Recipe = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            
        }
    }
}
