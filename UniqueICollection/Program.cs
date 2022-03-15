//using System.Collections.Generic;
namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueCollection<int> numCollection = new UniqueCollection<int>();

            for (int i = 0; i < 5; i++)
            {
                numCollection.Add(i);
            }

            numCollection.Add(1);

            System.Console.WriteLine($"\n4 contains in the collection? {numCollection.Contains(4)} ");
            System.Console.WriteLine($"20 contains in the collection? {numCollection.Contains(20)} ");

            System.Console.WriteLine($"\nThe collection: \n{numCollection.ToString()}");
            numCollection.Remove(3);
            System.Console.WriteLine($"The collection: \n{numCollection.ToString()}");

            System.Console.WriteLine("********************************************");

            UniqueCollection<string> strCollection = new UniqueCollection<string>();

            strCollection.Add("Tyrannosaurus");
            strCollection.Add("Amargasaurus");
            strCollection.Add("Mamenchisaurus");
            strCollection.Add("Brachiosaurus");
            strCollection.Add("Compsognathus");
            System.Console.WriteLine();

            string[] array = new string[15];

            strCollection.CopyTo(array, 6);

            System.Console.WriteLine($"The collection: \n{strCollection.ToString()}");

            System.Console.WriteLine("Contents of the array:");
            foreach (string item in strCollection)
            {
                System.Console.WriteLine(item);
            }




        }
    }
}