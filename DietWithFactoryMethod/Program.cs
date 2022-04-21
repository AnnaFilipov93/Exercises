namespace DietWithFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the diet you want:");
            string? diet = Console.ReadLine();

            if (diet == "" || diet == null)
            {
                System.Console.WriteLine("You did not enter a diet.");
            }
            else if ("vegandiet".Contains(diet.ToLower()))
            {
                ClientCode(new VeganDietFactory());
            }
            else if ("vegetariandiet".Contains(diet.ToLower()))
            {
                ClientCode(new VegetarianDietFactory());
            }
            else if ("juicedietFactory".Contains(diet.ToLower()))
            {
                ClientCode(new JuiceDietFactory());
            }
            else
            {
                System.Console.WriteLine("The diet do not exist.");
            }

        }

        public static void ClientCode(DietFactory creator)
        {
            Console.WriteLine(creator.SomeMenu());
        }
    }
}