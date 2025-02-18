using System;
using System.Collections.Generic;

interface IMealPlan
{
    string MealType { get; }
    void DisplayMeal();
}

// Vegetarian Meal Implementation
class VegetarianMeal : IMealPlan
{
    public string MealType => "Vegetarian";

    public void DisplayMeal()
    {
        Console.WriteLine("Vegetarian Meal: Grilled vegetables, lentil soup, and brown rice.");
    }
}

// Vegan Meal Implementation
class VeganMeal : IMealPlan
{
    public string MealType => "Vegan";

    public void DisplayMeal()
    {
        Console.WriteLine("Vegan Meal: Tofu stir-fry, quinoa salad, and almond milk smoothie.");
    }
}

// Keto Meal Implementation
class KetoMeal : IMealPlan
{
    public string MealType => "Keto";

    public void DisplayMeal()
    {
        Console.WriteLine("Keto Meal: Grilled salmon, avocado salad, and cauliflower rice.");
    }
}

// High-Protein Meal Implementation
class HighProteinMeal : IMealPlan
{
    public string MealType => "High-Protein";

    public void DisplayMeal()
    {
        Console.WriteLine("High-Protein Meal: Chicken breast, boiled eggs, and Greek yogurt.");
    }
}

// Generic Meal Class
class Meal<T> where T : IMealPlan, new()
{
    public T MealPlan { get; set; }

    public Meal()
    {
        MealPlan = new T();
    }

    public void ShowMeal()
    {
        Console.WriteLine($"[Meal Type: {MealPlan.MealType}]");
        MealPlan.DisplayMeal();
    }
}

// Meal Plan Generator
class MealPlanGenerator
{
    public static void GenerateMealPlan<T>() where T : IMealPlan, new()
    {
        Meal<T> meal = new Meal<T>();
        meal.ShowMeal();
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Personalized Meal Plan Generator ===\n");

        
        MealPlanGenerator.GenerateMealPlan<VegetarianMeal>();
        MealPlanGenerator.GenerateMealPlan<VeganMeal>();
        MealPlanGenerator.GenerateMealPlan<KetoMeal>();
        MealPlanGenerator.GenerateMealPlan<HighProteinMeal>();
    }
}
