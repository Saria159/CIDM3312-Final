using Microsoft.EntityFrameworkCore;

namespace FinalProj.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Recipes.Any())
        {
            return;
        }

        List<Ingredient> ingredients = new List<Ingredient>
        {
            new Ingredient { IngredientName = "Bread", IngredientQuantity = 2, IngredientCalorie = 160 }, //1
            new Ingredient { IngredientName = "Cheese", IngredientQuantity = 2, IngredientCalorie = 140 }, //2
            new Ingredient { IngredientName = "Butter", IngredientQuantity = 1, IngredientCalorie = 100 }, //3
            new Ingredient { IngredientName = "Eggs", IngredientQuantity = 2, IngredientCalorie = 140 }, //4
            new Ingredient { IngredientName = "Milk", IngredientQuantity = 1, IngredientCalorie = 120 }, //5
            new Ingredient { IngredientName = "Apple", IngredientQuantity = 1, IngredientCalorie = 95 }, //6 
            new Ingredient { IngredientName = "Banana", IngredientQuantity = 1, IngredientCalorie = 105 },//7
            new Ingredient { IngredientName = "Chicken Breast", IngredientQuantity = 1, IngredientCalorie = 180 }, //8
            new Ingredient { IngredientName = "Potato", IngredientQuantity = 1, IngredientCalorie = 110 }, //9
            new Ingredient { IngredientName = "Chocolate Chips", IngredientQuantity = 2, IngredientCalorie = 140 }, //10
            new Ingredient { IngredientName = "Carrot", IngredientQuantity = 2, IngredientCalorie = 50 }, //11
            new Ingredient { IngredientName = "Celery", IngredientQuantity = 3, IngredientCalorie = 30 }, //12
            new Ingredient { IngredientName = "Onion", IngredientQuantity = 1, IngredientCalorie = 45 }, //13
            new Ingredient { IngredientName = "Tomato", IngredientQuantity = 1, IngredientCalorie = 22 }, //14
            new Ingredient { IngredientName = "Lettuce", IngredientQuantity = 1, IngredientCalorie = 5 }, //15
            new Ingredient { IngredientName = "Ground Beef", IngredientQuantity = 1, IngredientCalorie = 250 }, //16
            new Ingredient { IngredientName = "Pasta", IngredientQuantity = 1, IngredientCalorie = 200 }, //17
            new Ingredient { IngredientName = "Rice", IngredientQuantity = 1, IngredientCalorie = 205 }, //18
            new Ingredient { IngredientName = "Olive Oil", IngredientQuantity = 1, IngredientCalorie = 120 }, //19
            new Ingredient { IngredientName = "Garlic", IngredientQuantity = 2, IngredientCalorie = 10 }, //20
            new Ingredient { IngredientName = "Salt", IngredientQuantity = 1, IngredientCalorie = 0 }, //21
            new Ingredient { IngredientName = "Pepper", IngredientQuantity = 1, IngredientCalorie = 0 }, //22
            new Ingredient { IngredientName = "Beef Broth", IngredientQuantity = 1, IngredientCalorie = 15 }, //23
            new Ingredient { IngredientName = "Tomato Sauce", IngredientQuantity = 1, IngredientCalorie = 70 }, //24
            new Ingredient { IngredientName = "Tortilla", IngredientQuantity = 2, IngredientCalorie = 210 }, //25
            new Ingredient { IngredientName = "Sour Cream", IngredientQuantity = 1, IngredientCalorie = 60 }, //26
            new Ingredient { IngredientName = "Yogurt", IngredientQuantity = 1, IngredientCalorie = 100 }, //27
            new Ingredient { IngredientName = "Strawberries", IngredientQuantity = 4, IngredientCalorie = 25 }, //28
            new Ingredient { IngredientName = "Blueberries", IngredientQuantity = 1, IngredientCalorie = 85 }, //29
            new Ingredient { IngredientName = "Spinach", IngredientQuantity = 1, IngredientCalorie = 7 }, //30
            new Ingredient { IngredientName = "Salmon", IngredientQuantity = 1, IngredientCalorie = 280 }, //31
            new Ingredient { IngredientName = "Shrimp", IngredientQuantity = 1, IngredientCalorie = 120 }, //32
            new Ingredient { IngredientName = "Beef Steak", IngredientQuantity = 1, IngredientCalorie = 300 }, //33
            new Ingredient { IngredientName = "Pork Chop", IngredientQuantity = 1, IngredientCalorie = 260 }, //34
            new Ingredient { IngredientName = "Cucumber", IngredientQuantity = 1, IngredientCalorie = 16 }, //35
            new Ingredient { IngredientName = "Avocado", IngredientQuantity = 1, IngredientCalorie = 240 }, //36
            new Ingredient { IngredientName = "Oats", IngredientQuantity = 1, IngredientCalorie = 150 }, //37
            new Ingredient { IngredientName = "Honey", IngredientQuantity = 1, IngredientCalorie = 64 } //38

        };
        context.AddRange(ingredients);
        context.SaveChanges();

        List<Recipe> recipes = new List<Recipe>
        {
            new Recipe { RecipeName = "Grilled Cheese", RecipeDesc = "Toasted bread with melted cheese inside", TotalCalories = 700 },
            new Recipe { RecipeName = "Pancakes", RecipeDesc = "Fluffy breakfast cakes served with syrup", TotalCalories = 360 },
            new Recipe { RecipeName = "Fruit Salad", RecipeDesc = "Mixed fresh fruits with a light dressing", TotalCalories = 200 },
            new Recipe { RecipeName = "Chicken Soup", RecipeDesc = "Warm broth with chicken and vegetables", TotalCalories = 305 },
            new Recipe { RecipeName = "Smoothie", RecipeDesc = "Blended fruits with yogurt or milk", TotalCalories = 225 },
            new Recipe { RecipeName = "Baked Potato", RecipeDesc = "Ovenbaked potato topped with butter", TotalCalories = 210 },
            new Recipe { RecipeName = "Chocolate Chip Cookies", RecipeDesc = "Sweet baked cookies with chocolate chips", TotalCalories = 380 },
            new Recipe { RecipeName = "Beef Tacos", RecipeDesc = "Seasoned beef in tortillas", TotalCalories = 487 },
            new Recipe { RecipeName = "Spaghetti", RecipeDesc = "Pasta with tomato sauce", TotalCalories = 225 },
            new Recipe { RecipeName = "Salad Bowl", RecipeDesc = "Fresh greens with vegetables", TotalCalories = 267 },
            new Recipe { RecipeName = "Beef Stir Fry", RecipeDesc = "Beef with vegetables in oil", TotalCalories = 435 },
            new Recipe { RecipeName = "Shrimp Pasta", RecipeDesc = "Pasta with shrimp and garlic", TotalCalories = 226 },
            new Recipe { RecipeName = "Salmon Plate", RecipeDesc = "Baked salmon with veggies", TotalCalories = 420 },
            new Recipe { RecipeName = "Yogurt Parfait", RecipeDesc = "Yogurt with fruit and honey", TotalCalories = 274 },
            new Recipe { RecipeName = "Oatmeal Bowl", RecipeDesc = "Warm oats with fruit", TotalCalories = 334 },
            new Recipe { RecipeName = "Avocado Toast", RecipeDesc = "Toast topped with avocado", TotalCalories = 310 },
            new Recipe { RecipeName = "Veggie Wrap", RecipeDesc = "Tortilla filled with vegetables", TotalCalories = 477 },
            new Recipe { RecipeName = "Steak Dinner", RecipeDesc = "Grilled steak with sides", TotalCalories = 510 },
            new Recipe { RecipeName = "Pork Chop Meal", RecipeDesc = "Cooked pork chop with veggies", TotalCalories = 480 },
            new Recipe { RecipeName = "Berry Smoothie", RecipeDesc = "Blended berries with yogurt", TotalCalories = 230 },
            new Recipe { RecipeName = "Garlic Rice", RecipeDesc = "Rice cooked with garlic", TotalCalories = 790 },
            new Recipe { RecipeName = "Tomato Soup", RecipeDesc = "Warm tomato based soup", TotalCalories = 82 },
            new Recipe { RecipeName = "Chicken Wrap", RecipeDesc = "Chicken and veggies in tortilla", TotalCalories = 395 },
            new Recipe { RecipeName = "Fruit Yogurt Bowl", RecipeDesc = "Fruit mixed with yogurt", TotalCalories = 310 },
            new Recipe { RecipeName = "Shrimp Salad", RecipeDesc = "Shrimp over fresh greens", TotalCalories = 153 },
            new Recipe { RecipeName = "Spinach Omelette", RecipeDesc = "Egg omelette with spinach", TotalCalories = 260 },
            new Recipe { RecipeName = "Honey Oat Bars", RecipeDesc = "Oats mixed with honey", TotalCalories = 214 },
            new Recipe { RecipeName = "Cucumber Salad", RecipeDesc = "Light cucumber based salad", TotalCalories = 261 },
            new Recipe { RecipeName = "Tomato Pasta", RecipeDesc = "Pasta with tomato and garlic", TotalCalories = 224 },
            new Recipe { RecipeName = "Avocado Salad", RecipeDesc = "Avocado mixed with greens", TotalCalories = 267 },
            new Recipe { RecipeName = "Blueberry Oat Muffin", RecipeDesc = "Soft muffin with blueberries", TotalCalories = 335 },
            new Recipe { RecipeName = "Strawberry Bowl", RecipeDesc = "Fresh strawberries with honey", TotalCalories = 89 }
        };
        context.AddRange(recipes);
        context.SaveChanges();

        List<RecipeIngredient> RecipeIngredients = new List<RecipeIngredient>
        {
            // Grilled Cheese | Bread, Cheese, Butter
            new RecipeIngredient { RecipeID = 1, IngredientID = 1 },
            new RecipeIngredient { RecipeID = 1, IngredientID = 2 },
            new RecipeIngredient { RecipeID = 1, IngredientID = 3 },

            // Pancakes | Eggs, Milk, Butter
            new RecipeIngredient { RecipeID = 2, IngredientID = 4 },
            new RecipeIngredient { RecipeID = 2, IngredientID = 5 },
            new RecipeIngredient { RecipeID = 2, IngredientID = 3 },

            // Fruit Salad | Apple, Banana
            new RecipeIngredient { RecipeID = 3, IngredientID = 6 },
            new RecipeIngredient { RecipeID = 3, IngredientID = 7 },

            // Chicken Soup | Chicken Breast, Carrot, Celery, Onion
            new RecipeIngredient { RecipeID = 4, IngredientID = 8 },
            new RecipeIngredient { RecipeID = 4, IngredientID = 11 },
            new RecipeIngredient { RecipeID = 4, IngredientID = 12 },
            new RecipeIngredient { RecipeID = 4, IngredientID = 13 },

            // Smoothie | Banana, Milk
            new RecipeIngredient { RecipeID = 5, IngredientID = 7 },
            new RecipeIngredient { RecipeID = 5, IngredientID = 5 },

            // Baked Potato | Potato, Butter
            new RecipeIngredient { RecipeID = 6, IngredientID = 9 },
            new RecipeIngredient { RecipeID = 6, IngredientID = 3 },

            // Chocolate Chip Cookies | Eggs, Butter, Chocolate Chips
            new RecipeIngredient { RecipeID = 7, IngredientID = 4 },
            new RecipeIngredient { RecipeID = 7, IngredientID = 3 },
            new RecipeIngredient { RecipeID = 7, IngredientID = 10 },

            // Beef Tacos | Ground Beef, Tortilla, Lettuce, Tomato
            new RecipeIngredient { RecipeID = 8, IngredientID = 16 },
            new RecipeIngredient { RecipeID = 8, IngredientID = 25 },
            new RecipeIngredient { RecipeID = 8, IngredientID = 15 },
            new RecipeIngredient { RecipeID = 8, IngredientID = 14 },

            // Spaghetti | Pasta, Tomato Sauce, Garlic
            new RecipeIngredient { RecipeID = 9, IngredientID = 17 },
            new RecipeIngredient { RecipeID = 9, IngredientID = 14 },
            new RecipeIngredient { RecipeID = 9, IngredientID = 20 },

            // Salad Bowl | Lettuce, Tomato, Cucumber
            new RecipeIngredient { RecipeID = 10, IngredientID = 15 },
            new RecipeIngredient { RecipeID = 10, IngredientID = 14 },
            new RecipeIngredient { RecipeID = 10, IngredientID = 36 },

            // Beef Stir Fry | Beef Steak, Olive Oil, Onion, Garlic
            new RecipeIngredient { RecipeID = 11, IngredientID = 34 },
            new RecipeIngredient { RecipeID = 11, IngredientID = 19 },
            new RecipeIngredient { RecipeID = 11, IngredientID = 13 },
            new RecipeIngredient { RecipeID = 11, IngredientID = 20 },

            // Shrimp Pasta | Shrimp, Pasta, Garlic
            new RecipeIngredient { RecipeID = 12, IngredientID = 35 },
            new RecipeIngredient { RecipeID = 12, IngredientID = 17 },
            new RecipeIngredient { RecipeID = 12, IngredientID = 20 },

            // Salmon Plate | Salmon, Spinach
            new RecipeIngredient { RecipeID = 13, IngredientID = 33 },
            new RecipeIngredient { RecipeID = 13, IngredientID = 32 },

            // Yogurt Parfait | Yogurt, Strawberries, Blueberries, Honey
            new RecipeIngredient { RecipeID = 14, IngredientID = 27 },
            new RecipeIngredient { RecipeID = 14, IngredientID = 28 },
            new RecipeIngredient { RecipeID = 14, IngredientID = 29 },
            new RecipeIngredient { RecipeID = 14, IngredientID = 38 },

            // Oatmeal Bowl | Oats, Milk, Honey
            new RecipeIngredient { RecipeID = 15, IngredientID = 37 },
            new RecipeIngredient { RecipeID = 15, IngredientID = 5 },
            new RecipeIngredient { RecipeID = 15, IngredientID = 38 },

            // Avocado Toast | Bread, Avocado
            new RecipeIngredient { RecipeID = 16, IngredientID = 1 },
            new RecipeIngredient { RecipeID = 16, IngredientID = 37 },

            // Veggie Wrap | Tortilla, Lettuce, Tomato, Cucumber
            new RecipeIngredient { RecipeID = 17, IngredientID = 25 },
            new RecipeIngredient { RecipeID = 17, IngredientID = 15 },
            new RecipeIngredient { RecipeID = 17, IngredientID = 14 },
            new RecipeIngredient { RecipeID = 17, IngredientID = 36 },

            // Steak Dinner | Beef Steak, Potato, Butter
            new RecipeIngredient { RecipeID = 18, IngredientID = 33 },
            new RecipeIngredient { RecipeID = 18, IngredientID = 9 },
            new RecipeIngredient { RecipeID = 18, IngredientID = 3 },

            // Pork Chop Meal | Pork Chop, Rice
            new RecipeIngredient { RecipeID = 19, IngredientID = 34 },
            new RecipeIngredient { RecipeID = 19, IngredientID = 18 },

            // Berry Smoothie | Strawberries, Blueberries, Milk
            new RecipeIngredient { RecipeID = 20, IngredientID = 28 },
            new RecipeIngredient { RecipeID = 20, IngredientID = 29 },
            new RecipeIngredient { RecipeID = 20, IngredientID = 5 },

            // Garlic Rice | Rice, Garlic, Olive Oil
            new RecipeIngredient { RecipeID = 21, IngredientID = 18 },
            new RecipeIngredient { RecipeID = 21, IngredientID = 20 },
            new RecipeIngredient { RecipeID = 21, IngredientID = 19 },

            // Tomato Soup | Tomato, Tomato Sauce, Onion
            new RecipeIngredient { RecipeID = 22, IngredientID = 14 },
            new RecipeIngredient { RecipeID = 22, IngredientID = 23 },
            new RecipeIngredient { RecipeID = 22, IngredientID = 13 },

            // Chicken Wrap | Chicken Breast, Tortilla, Lettuce
            new RecipeIngredient { RecipeID = 23, IngredientID = 8 },
            new RecipeIngredient { RecipeID = 23, IngredientID = 25 },
            new RecipeIngredient { RecipeID = 23, IngredientID = 15 },

            // Fruit Yogurt Bowl | Yogurt, Apple, Banana
            new RecipeIngredient { RecipeID = 24, IngredientID = 27 },
            new RecipeIngredient { RecipeID = 24, IngredientID = 6 },
            new RecipeIngredient { RecipeID = 24, IngredientID = 7 },

            // Shrimp Salad | Shrimp, Lettuce, Tomato
            new RecipeIngredient { RecipeID = 25, IngredientID = 35 },
            new RecipeIngredient { RecipeID = 25, IngredientID = 15 },
            new RecipeIngredient { RecipeID = 25, IngredientID = 14 },

            // Spinach Omelette | Eggs, Spinach
            new RecipeIngredient { RecipeID = 26, IngredientID = 4 },
            new RecipeIngredient { RecipeID = 26, IngredientID = 32 },

            // Honey Oat Bars | Oats, Honey
            new RecipeIngredient { RecipeID = 27, IngredientID = 37 },
            new RecipeIngredient { RecipeID = 27, IngredientID = 38 },

            // Cucumber Salad | Cucumber, Lettuce
            new RecipeIngredient { RecipeID = 28, IngredientID = 36 },
            new RecipeIngredient { RecipeID = 28, IngredientID = 15 },
            new RecipeIngredient { RecipeID = 28, IngredientID = 35 },

            // Tomato Pasta | Pasta, Tomato Sauce, Garlic
            new RecipeIngredient { RecipeID = 29, IngredientID = 17 },
            new RecipeIngredient { RecipeID = 29, IngredientID = 23 },
            new RecipeIngredient { RecipeID = 29, IngredientID = 20 },

            // Avocado Salad | Avocado, Lettuce, Tomato
            new RecipeIngredient { RecipeID = 30, IngredientID = 36 },
            new RecipeIngredient { RecipeID = 30, IngredientID = 15 },
            new RecipeIngredient { RecipeID = 30, IngredientID = 14 },

            // Blueberry Oat Muffin | Blueberries, Oats, Milk
            new RecipeIngredient { RecipeID = 31, IngredientID = 29 },
            new RecipeIngredient { RecipeID = 31, IngredientID = 37 },
            new RecipeIngredient { RecipeID = 31, IngredientID = 5 },

            // Strawberry Bowl | Strawberries, Honey
            new RecipeIngredient { RecipeID = 32, IngredientID = 28 },
            new RecipeIngredient { RecipeID = 32, IngredientID = 38 }
        };

        context.AddRange(RecipeIngredients);
        context.SaveChanges();
    }
}