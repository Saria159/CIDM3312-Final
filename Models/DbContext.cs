using Microsoft.EntityFrameworkCore;

namespace FinalProj.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeIngredient>().HasKey(s => new {s.RecipeID, s.IngredientID});
    }

    public DbSet<Ingredient> Ingredients {get; set;}
    public DbSet<Recipe> Recipes {get; set;}
    public DbSet<RecipeIngredient> RecipeIngredients {get; set;}
}