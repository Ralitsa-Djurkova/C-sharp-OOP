using System;

namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] pizzaArgs = Console.ReadLine().Split();
                Pizza pizza = new Pizza(pizzaArgs[1]);
                string[] doughArgs = Console.ReadLine().Split();
                Dough dough = new Dough(doughArgs[1], doughArgs[2], double.Parse(doughArgs[3]));
                pizza.Dough = dough;

                string toppingInput = Console.ReadLine();

                while (toppingInput != "END")
                {
                    string[] toppingArgs = toppingInput.Split();
                    Topping topping = new Topping(toppingArgs[1], double.Parse(toppingArgs[2]));
                    pizza.AddTopping(topping);

                    toppingInput = Console.ReadLine();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (ArgumentException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
           
        }
    }
}
