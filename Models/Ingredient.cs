using System.ComponentModel.DataAnnotations;

namespace FinalProj.Models;

public class Ingredient
{
    public int IngredientID {get; set;} // Primary Key

    [Display(Name = "Ingredient Name")]
    public string IngredientName {get; set;} = string.Empty;

    [Display(Name = "Ingredient Calorie")]
    public decimal IngredientCalorie {get; set;}

    [Display(Name = "Ingredient Quantity")]
    public int IngredientQuantity {get;set;}

    public List<RecipeIngredient>? RecipeIngredients {get; set;} = default!;
}

public class RecipeIngredient
{
    public int IngredientID {get; set;} // Composite Primary Key, Foreign Key 1
    public int RecipeID {get; set;} // Composite Primary Key, Foreign Key 2
    public Recipe Recipe {get; set;} = default!; // Navigation Property
    public Ingredient Ingredient {get; set;} = default!; // Navigation Property
}

