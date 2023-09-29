// See https://aka.ms/new-console-template for more information


// 1. Create a new console application
//Project 1: Build a calculator to perform arithmetic operations.

Console.WriteLine("Simple Calculator");
Console.WriteLine("Choose an operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

string operation = "";
string choice = "";

do
{
    Console.WriteLine("Choose your options: ");
    operation = Console.ReadLine();

    Console.WriteLine("Enter first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(operation == "1")
    {
        Console.WriteLine($"The result is: {num1 + num2}");
    }
    else if(operation == "2")
    {
        Console.WriteLine($"The result is: {num1 - num2}");
    }
    else if(operation == "3")
    {
        Console.WriteLine($"The result is: {num1 * num2}");
    }
    else if(operation == "4")
    {
        Console.WriteLine($"The result is: {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Invalid operation");
    }

    Console.WriteLine("Do you want to continue? (y/n)");
    choice = Console.ReadLine();

    
} while (choice == "y");

