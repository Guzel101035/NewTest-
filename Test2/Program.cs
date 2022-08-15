// 12.Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число кратным 
// первому. Если число 2 не кратно числу 1, то программа 
// выводит остаток от деления.
// 34,5 -> не кратно, остаток 4
// 16, 4 -> кратно
using static System.Console;
Clear();

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine());



if(number1 % number2 == 0)
{
    Console.WriteLine( "кратно");
}

else
{
    int result = number1 % number2;
    Console.WriteLine($"не кратно, остаток { result }");     
}




