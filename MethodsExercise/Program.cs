namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite sport?");
            string sport = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine($"Your favorite color is {color}");
            Console.WriteLine($"Your favroite sport is {sport}");




        }
    }
}
