public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }

    public Person(int age)
        :this()
    {
        this.Name = "No name";
        this.Age = age;
    }

    public Person(int age, string name)
        :this()
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Age}";
    }
}

