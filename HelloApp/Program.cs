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
