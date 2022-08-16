// 10. Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
using static System.Console;
Clear();
Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
 
int number1 = number / 10;
int number2 = number1 % 10;

Console.WriteLine(number2);
