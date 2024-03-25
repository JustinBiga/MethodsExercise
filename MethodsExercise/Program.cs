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

            // Math section

            Console.WriteLine("do some  math, enter two number to add.");

            //Addition Method

            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int sum = Add(num1, num2);

            Console.WriteLine($"the answer is {sum}");

            Console.WriteLine("do the math, enter two number to subtract");

            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int sub = subtract(num3, num4);


            Console.WriteLine($"The answer is {sub}");

            Console.WriteLine("Enter two number to multiply");

            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int answerMultiply = Multiply(num5, num6);

            Console.WriteLine($"the answer is {answerMultiply}");

            Console.WriteLine("Enter two number to divide");

            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());
            int answerDivide = Divide(num7, num8);
            Console.WriteLine($"The answer is {answerDivide}");
        }

        // Exercise 2

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        static int subtract(int num3, int num4)
        {
            return num3 - num4;
        }

        static int Multiply(int num5, int num6)
        {
            return num5 * num6;
        }

        static int Divide(int num7, int num8)
        {
            return num7 / num8;
        }
    }

}