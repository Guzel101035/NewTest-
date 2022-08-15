// на вход два числа и проверяет , является ли одно число квадратом другого.
// 5, 25 -> да
using static System.Console;
Clear();

Console.WriteLine("Inter number1");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inter number2");
int number2= int.Parse(Console.ReadLine());


if( number1 / number2 == number2 || number2 / number1 == number1 )
{
    Console.WriteLine( "Es");
}

else
{
    Console.WriteLine("No");     
}

