using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        ICollection<Person> givenPersons = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine()?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = command[0];
            int age = Convert.ToInt32(command[1]);

            Person newPerson = new Person(age, name);
            givenPersons.Add(newPerson);
        }

        Console.WriteLine(string.Join(Environment.NewLine, givenPersons.Where(x => x.Age > 30).OrderBy(x => x.Name)));
    }
}

