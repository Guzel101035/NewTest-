// 13. Напишите программу,которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(ReadLine());

int number1 = number / 100;
if( number1 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
   int number2 = number % 10;
   Console.WriteLine(number2);
}

         

    



    




