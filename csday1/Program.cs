// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num1, num2, num3,num4;


Console.WriteLine("Enter a four digit number: ");
string numberEntered = Console.ReadLine();

num1 = Convert.ToInt32(numberEntered.Substring(0, 1));
num2 = Convert.ToInt32(numberEntered.Substring(1, 1));   
num3 = Convert.ToInt32(numberEntered.Substring(2, 1));
num4 = Convert.ToInt32(numberEntered.Substring(3, 1));
Console.WriteLine("The sum of the four numbers are: " + (num1 + num2 + num3 + num4));



//TO DO