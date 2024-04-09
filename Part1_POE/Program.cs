using System;

internal class ProgramPart1
{
    public class Ingredients
    {
        public string name;
        public double quantity;
        public string unitsOfMeasurements;
    }

    private static void Main(string[] args)
    {
        RecipeDetails();
    }

    public static void RecipeDetails()
    {
        Console.WriteLine("Enter the followig details for a single recipe");
        Console.WriteLine("Enter the number of ingredients: ");
        int numIng = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number of ingredients chosen are: " + numIng);

        for (int i = 0; i < numIng; i++) 
        {
            Console.WriteLine("Enter the name of the ingredient");
            string nameIng = Console.ReadLine();
            Console.WriteLine("Enter the quantity of the ingredient");
            double quantityIng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the unit of measurement of the ingredient");
            string unitsMe = Console.ReadLine();
        }
    }
}