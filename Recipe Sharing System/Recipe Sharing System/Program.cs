using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe_Sharing_System
{
    class Program
    {
        static List<User> users = new List<User>();
        static List<Recipe> recipes = new List<Recipe>();
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("RECIPE SHARING SYSTEM");
                    Console.WriteLine("1.Register");
                    Console.WriteLine("2.Login");
                    Console.WriteLine("3.Exit");

                    Console.WriteLine("Choose an option: ");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Register();
                            break;
                        case 2:
                            Login();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option.Please Choose again.");
                            break;
                    }
                }

              catch (FormatException)
                {
                    Console.WriteLine("invalid input. please enter a number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }


        static void Register()
        {
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            User user = new User(username, password, email);
            users.Add(user);
            Console.WriteLine("Registration successful!");
        }

        static void Login()
        {
            try
            {
                Console.WriteLine("Enter Username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                foreach (User user in users)
                {
                    if (user.Username == username && user.Password == password)
                    {
                        Console.WriteLine("Login succesful!");
                        Dashboard(user);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login failed: " + ex.Message);
            }
        }

        static void Dashboard(User user)
                {
                    while(true)
                    {
                        Console.WriteLine("Dashboard");
                        Console.WriteLine("1.Submit Recipe");
                        Console.WriteLine("2.view Recipe");
                        Console.WriteLine("3.Rate Recipe");
                        Console.WriteLine("4.Meal planning");
                        Console.WriteLine("5.Logout");

                        Console.WriteLine("Choose an option: ");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                SubmitRecipe(user);
                                break;
                            case 2:
                                ViewRecipes();
                                break;
                            case 3:
                                RateRecipe();
                                break;
                            case 4:
                                MealPlanning();
                                break;
                            case 5:
                                return;
                            default:
                            Console.WriteLine("Invalid option.please choose again.");
                                break;
                        }
                    }
                }

        static void SubmitRecipe(User user)
        {
            Console.WriteLine("Enter recipe title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter recipe description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter recipe ingredients: ");
            string ingredients = Console.ReadLine();
            Console.WriteLine("Enter recipe instructions:");
            string instructions = Console.ReadLine();

            Recipe recipe = new Recipe(title, description, ingredients, instructions, user);
            recipes.Add(recipe);

            Console.WriteLine("Recipe submitted successful!");


        }
       

        static void ViewRecipes()
        {
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine("Title: " + recipe.Title);
                Console.WriteLine("Description: " + recipe.Description);
                Console.WriteLine("Ingredients: " + recipe.Ingredients);
                Console.WriteLine("Instructions:" + recipe.Instructions);
                Console.WriteLine("Submitted by: " + recipe.User.Username);
                Console.WriteLine();
            }
        }

        static void RateRecipe()
        {
            Console.WriteLine("Enter recipe title: ");
            string title = Console.ReadLine();

            foreach (Recipe recipe in recipes)
            {
                if (recipe.Title == title)
                {
                    Console.WriteLine("Enter rating (1-5): ");
                    int rating = Convert.ToInt32(Console.ReadLine());
                    recipe.Rating = rating;
                    Console.WriteLine("Recipe rated successfully!");
                    return;
                }
            }
        }
        static void MealPlanning()
        {
            Console.WriteLine("Meal Planning");
            Console.WriteLine("Coming soon...");
        }
    }
}
    


  
        

    


