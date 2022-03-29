using System.Text.Json;
namespace Serialization
{
    class Program
    {
        private static List<Student> students = Deserialize();
        public const int TUITUIONFEE = 10000;
        static void Main(string[] args)
        {

            string? input;
            bool keepLooping = true;

            while (keepLooping)
            {
                System.Console.WriteLine("Choose the next actionq:");
                System.Console.WriteLine("a\t - Add student");
                System.Console.WriteLine("r\t - Remove student");
                System.Console.WriteLine("p\t - Print all students in the file");
                System.Console.WriteLine("pf\t - Print students tuition fee report");
                System.Console.WriteLine("q\t - Quit");

                input = Console.ReadLine() ?? string.Empty.ToLower().Trim();

                switch (input)
                {
                    case "a":
                        AddStudent();
                        break;
                    case "r":
                        RemoveStudent();
                        break;
                    case "p":
                        PrintStudents();
                        break;
                    case "pf":
                        PrintStudentsTuitionFeeReport();
                        break;
                    case "q":
                        keepLooping = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public static List<Student> Deserialize()
        {
            string json = File.ReadAllText("students.json");
            List<Student>? studentsDes = JsonSerializer.Deserialize<List<Student>>(json);
            return studentsDes;
        }
        public static void Serialize(List<Student> students)
        {
            string json = JsonSerializer.Serialize(students);
            File.WriteAllText("students.json", json);
        }

        public static void AddStudent()
        {
            string name = "";
            int age = 0;

            while (name == "" || name == string.Empty)
            {
                Console.WriteLine("Enter student Name:");
                name = Console.ReadLine() ?? string.Empty.ToLower().Trim();
            }

            while (age == 0)
            {
                Console.WriteLine("Enter student Age:");
                try
                {
                    age = int.Parse(Console.ReadLine() ?? string.Empty.Trim());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input");
                    age = 0;
                }
            }

            Student newStudent = new Student(name, age);

            if (students != null)
            {
                foreach (Student student in students)
                {
                    if (newStudent.Name.ToLower().Trim() == student.Name.ToLower())
                    {
                        Console.WriteLine($"Student already exist");
                        return;
                    }
                }

            }

            students.Add(newStudent);
            Console.WriteLine($"The student was added");

            Serialize(students);
        }

        public static void RemoveStudent()
        {
            Console.WriteLine("Enter the name of the student:");
            string? name = Console.ReadLine();
            while (name == null || name == "")
            {
                Console.WriteLine("Enter a valid name:");
                name = Console.ReadLine();
            }
            foreach (Student student in students)
            {
                if (student.Name.ToLower().Trim() == name.ToLower())
                {
                    if (students.Remove(student))
                    {
                        Console.WriteLine($"The student been removed");
                    }
                    else
                    {
                        Console.WriteLine($"The student does not exist");
                    }
                    Serialize(students);
                    break;
                }
            }

        }
        public static void PrintStudents()
        {
            System.Console.WriteLine("\nThe students: ");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.ToString()}");
            }
            System.Console.WriteLine();
        }

        public static void PrintStudentsTuitionFeeReport()
        {
            System.Console.WriteLine("\nThe students tuition fee report: ");

            foreach (Student student in students)
            {
                if (student.Age >= 25)
                {
                    Console.WriteLine($"{student.ToString()} need to pay {TUITUIONFEE}");
                }
                else
                {
                    Console.WriteLine($"{student.ToString()} need to pay {TUITUIONFEE * 0.9}");
                }

            }
            System.Console.WriteLine();
        }

    }
}