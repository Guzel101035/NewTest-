// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
using static System.Console;
Clear();
int number = new Random().Next(100, 999);

int number1 = number / 100*10;
int number2 = number % 10;
 
Console.WriteLine(number);

Console.Write(number1 + number2);


