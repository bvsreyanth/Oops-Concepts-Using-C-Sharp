using System;

// Base class
public class Animal
{
    public string[] FavoriteFoods { get; set; }

    public Animal(string[] foods)
    {
        FavoriteFoods = foods;
    }

    public void PrintFavoriteFoods()
    {
        Console.Write("Favorite Foods: ");
        foreach (var food in FavoriteFoods)
        {
            Console.Write(food + " ");
        }
        Console.WriteLine();
    }
}
