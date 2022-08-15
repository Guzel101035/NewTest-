// на кратность на 7 и на 23.
using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());




if(( number % 7 == 0 &&  number % 23 == 0))
{
    Console.WriteLine( "Да");
}

else
{
    Console.WriteLine("Нет");     
}
