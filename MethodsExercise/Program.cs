using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi -What is your name?"); // output

            var userName = Console.ReadLine();


            Console.WriteLine($"Hi, {userName}. what is your favorite color?");

            var color = Console.ReadLine();

            Console.WriteLine("That is cool! what is your favorite place?");

            var place = Console.ReadLine();

            Console.WriteLine("interesting! what is your favorite band?");

            var band = Console.ReadLine();

            Console.WriteLine($"Awesome {userName}! Here is your profile");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite place: {place}");
            Console.WriteLine($"Favorite band: {band}");


        }

        





    }
}