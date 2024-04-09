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
        Console.WriteLine("***** Welcome to the Recipe Application *****");
        Console.WriteLine("Please enter the followig details for a single recipe");
        Console.WriteLine("Enter the number of ingredients: ");
        int numIng = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number of ingredients chosen are: " + numIng);

        Ingredients[] ingredients = new Ingredients[numIng];

        for (int i = 0; i < numIng; i++) 
        {
            Console.WriteLine("Enter the name of the ingredient: ");
            string nameIng = Console.ReadLine();
            Console.WriteLine("Enter the quantity (amount in numbers) of the ingredient: ");
            double quantityIng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the unit of measurement (measurement in words - for example teaspoon, gram, cup) of the ingredient:");
            string unitsMe = Console.ReadLine();

            ingredients[i] = new Ingredients
            {
                name = nameIng,
                quantity = quantityIng,
                unitsOfMeasurements = unitsMe,
            };
        }

        Console.WriteLine("Enter the number of steps required for this recipe: ");
        int numSteps = Convert.ToInt32(Console.ReadLine());

        string[] steps = new string[numSteps];
        for(int i = 0; i < numSteps; i++) 
        {
            Console.WriteLine("Step " + (i + 1) + " : ");
            steps[i] = Console.ReadLine();
        }

        double[] orgQuantities = new double[numIng];
        for(int i = 0; i < numIng; i++)
        {
            orgQuantities[i] = ingredients[i].quantity;
        }

        bool continueMenu = true;

        while( continueMenu ) 
        {
            Console.WriteLine("Choose a menu option (in the brackets) that you want to perform on the recipe ");
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
                    Console.WriteLine("---- Ingredients: ----");
                    foreach (var ingredient in ingredients)
                    {
                        Console.WriteLine(ingredient.name + "---- " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                    }
                    Console.WriteLine("---- Steps: ----");
                    for (int i = 0; i < numSteps; i++)
                    {
                        Console.WriteLine("Step " + (i + 1) + ": " + steps[i]);
                    }

                    break;
                case "S":
                    //
                    Console.WriteLine("Choose a scaling factor (enter the following scaling words in the brackets)");
                    Console.WriteLine("(Half) = 0.5");
                    Console.WriteLine("(Double) = 2");
                    Console.WriteLine("(Triple) = 3");
                    Console.WriteLine("(B) Go back");

                    string scalingFactor = Console.ReadLine();

                    switch(scalingFactor)
                    {
                        case "Half":
                            //
                            foreach(var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 0.5;
                            }
                            Console.WriteLine("---- Scaled recipe ----");
                            foreach (var ingredient in ingredients)
                            {
                                Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                            }
                            break;
                        case "Double":
                            //
                            foreach (var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 2;
                            }
                            Console.WriteLine("---- Scaled recipe ----");
                            foreach (var ingredient in ingredients)
                            {
                                Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                            }
                            break;
                        case "Triple":
                            //
                            foreach (var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 3;
                            }
                            Console.WriteLine("---- Scaled recipe ----");
                            foreach (var ingredient in ingredients)
                            {
                                Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                            }
                            break;
                        case "B":
                            //
                            continueMenu = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option entered, try again");
                            break;
                    }
                    break;
                case "R":
                    //
                    for(int i = 0; i < numIng; i++)
                    {
                        ingredients[i].quantity = orgQuantities[i];
                    }
                    Console.WriteLine("Recipe has been reset to original values");
                    break;
                case "C":
                    //
                    for (int i = 0; i < numIng; i++)
                    {
                        ingredients[i].quantity = 0;
                    }
                    for (int i = 0; i < numSteps; i++)
                    {
                        steps[i] = "";
                    }
                    Console.WriteLine("Data has been cleared. Enter new recipe details");
                    RecipeDetails();
                    break;
                case "E":
                    //
                    continueMenu = false;
                    break;
                default:
                    Console.WriteLine("Invalid option entered, try again");
                    break;
            }
        }
    }
}