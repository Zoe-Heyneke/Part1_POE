using System;

internal class ProgramPart1
{
    //declare and initialize variables used in program
    public class Ingredients
    {
        public string name;
        public double quantity;
        public string unitsOfMeasurements;
    }

    //in the main method is RecipeDetails() which ensures that all operations inside RecipeDetails() will run 
    private static void Main(string[] args)
    {
        RecipeDetails();
    }

    //expanding method RecipeDetails() by inputting operations
    public static void RecipeDetails()
    {
        //Welcome user to the app
        Console.WriteLine("***** Welcome to the Recipe Application *****");
        Console.WriteLine("Please enter the followig details for a single recipe");
        //Ask the user the number of ingredients and read user's input stored as numIng
        Console.WriteLine("Enter the number of ingredients: ");
        int numIng = Convert.ToInt32(Console.ReadLine());
        //Confirm with the user the number of ingredients entered
        Console.WriteLine("The number of ingredients chosen are: " + numIng);

        //create array for ingredients setting the size to numIng which is the number chosen by the user
        Ingredients[] ingredients = new Ingredients[numIng];

        //for loop because for each number of ingredient chosen by user it must ask the name, quantity, and units of measurement
        for (int i = 0; i < numIng; i++) 
        {
            //ask user to enter the name of the ingredient and store it as nameIng
            Console.WriteLine("Enter the name of the ingredient: ");
            string nameIng = Console.ReadLine();
            //ask user to enter te quantity of the ingredient and store it as quantityIng
            Console.WriteLine("Enter the quantity (amount in numbers) of the ingredient: ");
            double quantityIng = Convert.ToDouble(Console.ReadLine());
            //ask user to enter the unit of measurement and store it as unitsMe
            Console.WriteLine("Enter the unit of measurement (measurement in words - for example teaspoon, gram, cup) of the ingredient:");
            string unitsMe = Console.ReadLine();

            //create new object which is Ingredients which is assigned to ingredients[i] (this will help with positioning of the array)
            //variables are set to stored values of user input to be in the array of ingredients
            ingredients[i] = new Ingredients
            {
                name = nameIng,
                quantity = quantityIng,
                unitsOfMeasurements = unitsMe,
            };
        }

        //ask user to enter the number of steps needed for the recipe and stored as numSteps
        Console.WriteLine("Enter the number of steps required for this recipe: ");
        int numSteps = Convert.ToInt32(Console.ReadLine());

        //allows user to input a string of description of each step with the use of the string array which is set by the num of step entered by the user
        //ach step iterates to the next step
        string[] steps = new string[numSteps];
        for(int i = 0; i < numSteps; i++) 
        {
            Console.WriteLine("Step " + (i + 1) + " : ");
            steps[i] = Console.ReadLine();
        }

        //create a new array to store original data entered by user
        //new array of original ingredients is set to equally assign to the array of ingredients stored by the user's input (user dat stored as original values to refer back to reset reipe to original values)
        double[] orgQuantities = new double[numIng];
        for(int i = 0; i < numIng; i++)
        {
            orgQuantities[i] = ingredients[i].quantity;
        }

        //men is set to boolean value to ensure running menu
        //true = yes it will and false = stop running
        bool continueMenu = true;

        //while loop to ensure menu will loop while it is true until false it will stop looping
        while( continueMenu ) 
        {
            //display menu options to user
            Console.WriteLine("Choose a menu option (in the brackets) that you want to perform on the recipe ");
            Console.WriteLine("(D) Display full recipe");
            Console.WriteLine("(S) Scale recipe");
            Console.WriteLine("(R) Reset recipe");
            Console.WriteLine("(C) Clear data to enter a new recipe");
            Console.WriteLine("(E) Exit");

            //capture user input which is a string value
            string menu = Console.ReadLine();

            //switch case menu to perform each option chosen
            switch (menu)
            {
                case "D":
                    //display recipe
                    Console.WriteLine("******** Recipe details ********");
                    Console.WriteLine("---- Ingredients: ----");
                    //foreach loop to iterate over each ingredient in the array and display the values (properties of the ingredient object created) in the way of the Console.WriteLine
                    foreach (var ingredient in ingredients)
                    {
                        Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                    }
                    Console.WriteLine("---- Steps: ----");
                    //for loop to iterate through each step and display each step that the user entered
                    for (int i = 0; i < numSteps; i++)
                    {
                        Console.WriteLine("Step " + (i + 1) + ": " + steps[i]);
                    }
                    break;
                case "S":
                    //incorporate menu system for user to choose  scaling factor
                    Console.WriteLine("Choose a scaling factor (enter the following scaling words in the brackets)");
                    Console.WriteLine("(Half) = 0.5");
                    Console.WriteLine("(Double) = 2");
                    Console.WriteLine("(Triple) = 3");
                    Console.WriteLine("(B) Go back");

                    //capture user input which is a string value
                    string scalingFactor = Console.ReadLine();

                    ////switch case menu to perform each option chosen
                    switch (scalingFactor)
                    {
                        case "Half":
                            //multiply the quantity of the ingredient by 0.5 which is half
                            //foreach loop because for each ingredient the operation must be done
                            foreach(var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 0.5;
                            }
                            //display new scaled values of recipe ingredients to ease oprations so that user doesn't have to enter D again to display full recipe, but user can choose D again to display full recipe
                            Console.WriteLine("---- Scaled recipe ----");
                            foreach (var ingredient in ingredients)
                            {
                                Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                            }
                            break;
                        case "Double":
                            //multiply the quantity of the ingredient by 2 which is double
                            //foreach loop because for each ingredient the operation must be done
                            foreach (var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 2;
                            }
                            ////display new scaled values of recipe ingredients to ease oprations so that user doesn't have to enter D again to display full recipe, but user can choose D again to display full recipe
                            Console.WriteLine("---- Scaled recipe ----");
                            foreach (var ingredient in ingredients)
                            {
                                Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                            }
                            break;
                        case "Triple":
                            //multiply the quantity of the ingredient by 3 which is triple
                            //foreach loop because for each ingredient the operation must be done
                            foreach (var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 3;
                            }
                            ////display new scaled values of recipe ingredients to ease oprations so that user doesn't have to enter D again to display full recipe, but user can choose D again to display full recipe
                            Console.WriteLine("---- Scaled recipe ----");
                            foreach (var ingredient in ingredients)
                            {
                                Console.WriteLine(ingredient.name + ": " + ingredient.quantity + " " + ingredient.unitsOfMeasurements);
                            }
                            break;
                        case "B":
                            //go back to main menu
                            continueMenu = true;
                            break;
                        default:
                            //output message to user for inputting a wrong option
                            Console.WriteLine("Invalid option entered, try again");
                            break;
                    }
                    break;
                case "R":
                    //reset recipe
                    //for loop because for each ingredient's quantity changed by the scaling factor, it has to be reset to the original quantity values entered by the user that has been stored in the orgQuantities 
                    for(int i = 0; i < numIng; i++)
                    {
                        ingredients[i].quantity = orgQuantities[i];
                    }
                    //confirm the user that recipe has been reset
                    Console.WriteLine("Recipe has been reset to original values");
                    break;
                case "C":
                    //clear data
                    //for loop because for each ingredient in the array, the quantity must be cleared therefore equal to 0
                    for (int i = 0; i < numIng; i++)
                    {
                        ingredients[i].quantity = 0;
                    }
                    //for loop because for each step in the array, the description of the step must be cleared therefore "" creating empty values
                    for (int i = 0; i < numSteps; i++)
                    {
                        steps[i] = "";
                    }
                    //confirm the user hat data has been cleared and can now enter a new recipe's details
                    Console.WriteLine("Data has been cleared. Enter new recipe details");
                    //call method so that user can begin again to follow the steps again to enter a new recpe
                    RecipeDetails();
                    break;
                case "E":
                    //exit main menu
                    continueMenu = false;
                    break;
                default:
                    //output message to user for inputting a wrong option
                    Console.WriteLine("Invalid option entered, try again");
                    break;
            }
        }
    }
}