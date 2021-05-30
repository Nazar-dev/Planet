using System;
using Planet.Class;

namespace Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pause pause = new Pause();
            RandNumber rand = new RandNumber(30, 20);
            ConsoleOutput output = new ConsoleOutput(30,20);
            Food food = new Food(rand,output);
            Movement movement = new Movement();
            Factory factory = new Factory(rand, food,output,movement);
            FoodRepose foodRepose = new FoodRepose(factory);
            ReposetoriyBacteria reposetoriy = new ReposetoriyBacteria(factory);
            Logic logic = new Logic(output,factory,pause,reposetoriy,foodRepose);




            logic.runGame();
            Console.ReadLine();
        }
    }
}
