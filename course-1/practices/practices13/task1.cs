using System;

class Program
{
    static void Main()
    {
        var p = new Person();
        p.Name = "Алиса";
        p.Age = 25;
        p.Age = -5; // сообщение об ошибке
    }
}

public class Person
{
    private string _name;
    private int _age;

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Имя не может быть пустым или состоять только из пробелов.");
            _name = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                Console.WriteLine("Сообщение об ошибке");
            _age = value;
        }
    }
}