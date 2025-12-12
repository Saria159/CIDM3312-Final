using System.ComponentModel.DataAnnotations;

namespace FinalProj.Models;

public class Recipe
{
    public int RecipeID {get; set;} // Primary Key

    [Display(Name = "Recipe Name")]
    public string RecipeName {get; set;} = string.Empty;
    
    [Display(Name = "Recipe Description")]
    public string RecipeDesc {get; set;} = string.Empty;

    [Display(Name = "Total Calories")]
    public decimal TotalCalories {get;set;}

    [Display(Name = "Ingredients in Recipe")]
    public List<RecipeIngredient>? RecipeIngredients {get; set;} = default!;
}