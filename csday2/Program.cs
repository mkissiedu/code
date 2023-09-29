// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a fourth number: ");
int num4 = Convert.ToInt32(Console.ReadLine());

int largestNumber;
if (num1 > num2 && num1 > num3 && num1 > num4)
{
    largestNumber = num1;
    Console.WriteLine("The largest number is: " + largestNumber);
}
else if (num2 > num1 && num2 > num3 && num2 > num4)
{
    largestNumber = num2;
    Console.WriteLine("The largest number is: " + largestNumber);
}
else if (num3 > num1 && num3 > num2 && num3 > num4)
{
    largestNumber = num3;
    Console.WriteLine("The largest number is: " + largestNumber);
}
else
{
    largestNumber = num4;
    Console.WriteLine("The largest number is: " + largestNumber);
}