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

        Ingredients[] ingredients = new Ingredients[numIng];

        for (int i = 0; i < numIng; i++) 
        {
            Console.WriteLine("Enter the name of the ingredient");
            string nameIng = Console.ReadLine();
            Console.WriteLine("Enter the quantity of the ingredient");
            double quantityIng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the unit of measurement of the ingredient");
            string unitsMe = Console.ReadLine();

            ingredients[i] = new Ingredients
            {
                name = nameIng,
                quantity = quantityIng,
                unitsOfMeasurements = unitsMe,
            };
        }

        Console.WriteLine("Enter the number of steps required for this recipe");
        int numSteps = Convert.ToInt32(Console.ReadLine());

        string[] steps = new string[numSteps];
        for(int i = 0; i < numSteps; i++) 
        {
            Console.WriteLine("Step " + (i + 1) + " : ");
            steps[i] = Console.ReadLine();
        }

        bool continueMenu = true;

        while( continueMenu ) 
        {
            Console.WriteLine("(D) Display full recipe");
            Console.WriteLine("(S) Scale recipe");
            Console.WriteLine("(R) Reset recipe");
            Console.WriteLine("(C) Clear data to enter a new recipe");
            Console.WriteLine("(E) Exit");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "D":
                    //
                    Console.WriteLine("******** Recipe details ********");
                    Console.WriteLine("Ingredients:");
                    foreach (var ingredient in ingredients)
                    {
                        Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                    }
                    Console.WriteLine("Steps:");
                    for (int i = 0; i < numSteps; i++)
                    {
                        Console.WriteLine("Step " + (i + 1) + ": " + steps[i]);
                    }

                    break;
                case "S":
                    //
                    break;
                case "R":
                    //
                    break;
                case "C":
                    //
                    break;
                case "E":
                    //
                    break;
            }
        }
    }
}