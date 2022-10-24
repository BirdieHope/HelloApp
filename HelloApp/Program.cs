// See https://aka.ms/new-console-template for more information

using HelloApp;

Person tom = new Person();
//string personName=tom.name;
//int personAge=tom.age;
//Console.WriteLine("Имя: {0}. Возраст: {1}", personName, personAge);
tom.name = "Tom";
//tom.age = 37;
tom.Print();
Console.ReadLine();

/*
Console.WriteLine("Hello, World!");

string? name = " ";       // вводим имя
Console.Write("Введите имя ");
name = Console.ReadLine();   
Console.WriteLine($"Привет {name}");    
Console.ReadLine();

class Person
{
    public string name = "Undefinite";
    public int age;

    public void Print()
    {
        Console.WriteLine("Имя: {0}. Возраст: {1}", name, age);
    }

}
*/