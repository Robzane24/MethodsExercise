namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        
        public static int Mulitply(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            int addTwoNum = Sum(2, 6);
            int multiplyTwoNum = Mulitply(10, 2);


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
