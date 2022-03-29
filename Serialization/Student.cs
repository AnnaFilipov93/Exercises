using Serialization;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public override string ToString()
    {
        return $"{this.Name},{this.Age}";
    }
}