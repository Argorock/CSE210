using System;

class Program
{
    static void Main(string[] args)
    {

        var people = new List<Employee>();

        people.Add(new Faculty(name: "Marry"));
        people.Add(new TA(name: "John"));   
        people.Add(new Student(name: "Jane"));
        people.Add(new Faculty(name: "Tom"));
       
        foreach (var person in people)
        {
            person.display();
            Console.WriteLine("Payday: " + person.SetPayDay());
        }
    }
}