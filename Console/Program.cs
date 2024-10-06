// See https://aka.ms/new-console-template for more information


using ConsoleP;

Console.WriteLine("Ingrese un numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un numero");
int num2 = int.Parse(Console.ReadLine());

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Sum(num1, num2));





