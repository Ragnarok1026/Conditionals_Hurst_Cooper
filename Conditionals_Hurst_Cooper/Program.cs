// See https://aka.ms/new-console-template for more information
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("please enter a number");
int number1 = int.Parse(Console.ReadLine());

if (number1 > 0)
{
    Console.WriteLine("Number is Positive!");
}
else
{
    Console.WriteLine("Number is Negitive!");
}

if (number1 %2 == 0)
{
    Console.WriteLine("Number is Even");
}
else
{
    Console.WriteLine("Number is Odd");
}

Console.WriteLine(number1);

int number2 = int.Parse(Console.ReadLine());

if (number2 > 0)
{
    Console.WriteLine("Number is Positive!");
}
else
{
    Console.WriteLine("Number is Negitive!");
}

if (number2 % 2 == 0)
{
    Console.WriteLine("Number is Even");
}
else
{
    Console.WriteLine("Number is Odd");
}

Console.WriteLine(number2);

int number3 = int.Parse(Console.ReadLine());

if (number3 > 0)
{
    Console.WriteLine("Number is Positive!");
}
else
{
    Console.WriteLine("Number is Negitive!");
}

if (number3 % 2 == 0)
{
    Console.WriteLine("Number is Even");
}
else
{
    Console.WriteLine("Number is Odd");
}

Console.WriteLine(number3);

int Largest = Math.Max(number1, Math.Max(number2, number3));
Console.WriteLine($"Largest Number is {Largest}");

Console.WriteLine("Enter Grade(A, B, C, D, F)");
char Grade = char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine();
switch (Grade)
{
    case 'A':
        Console.WriteLine("Superior");
        break;
    case 'B':
        Console.WriteLine("Very Good");
        break;
    case 'C':
        Console.WriteLine("Average");
        break;
    case 'D':
        Console.WriteLine("Below Average");
        break;
    case 'F':
        Console.WriteLine("Fail!!!!");
        break;
    default:
        Console.WriteLine("You think you have free will?");
        break;
}





