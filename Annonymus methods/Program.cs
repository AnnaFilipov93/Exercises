namespace Annonymus
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> IsEven = delegate (int num) { return num % 2 == 0; };
            Func<int, bool> IsNotEven = delegate (int num) { return num % 2 != 0; };
            Func<int, bool> Has3 = delegate (int num)
            {
                while (num > 0)
                {
                    if (num % 10 == 3) return true;
                    num = num / 10;
                }
                return false;
            };
            Func<int, bool> HasSameNumberSequance = delegate (int num)
            {
                int digit;
                if (num < 10) return true;
                while (num > 10)
                {
                    digit = num % 10;
                    num = num / 10;
                    if (digit != num % 10) return false;
                }
                return true;
            };
            Func<int[], Func<int, bool>, int[]> GetFiltered = delegate (int[] arr, Func<int, bool> filter)
             {
                 int[] newArr = arr.Where(i => filter(i) == true).ToArray();
                 return newArr;
             };

            var Print = (int[] arr) =>
            {
                foreach (int i in arr)
                {
                    System.Console.Write($"{i} ");
                }

            };

            int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 };
            int[] evenArray = GetFiltered(array, IsEven);
            int[] notEvenArray = GetFiltered(array, IsNotEven);
            int[] has3Array = GetFiltered(array, Has3);
            int[] hasSameNumberArray = GetFiltered(array, HasSameNumberSequance);
            //
            System.Console.WriteLine("Original array items:");
            Print(array);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Even array items:");
            Print(evenArray);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Not even array items:");
            Print(notEvenArray);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Has 3 array items:");
            Print(has3Array);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Has same number array items:");
            Print(hasSameNumberArray);
            System.Console.WriteLine("\n********************");

        }
    }
}