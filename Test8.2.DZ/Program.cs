// 
using static System.Console;
Clear();
Write("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
if(a==1)
{
    Console.WriteLine("Пн-рабочий ");
}
if(a==2)
{
    Console.WriteLine("Вт-рабочий");
}
if(a==3)
{
    Console.WriteLine("Ср-рабочий");
}
if(a==4)
{
    Console.WriteLine("Чт-рабочий");
}
if(a==5)
{
    Console.WriteLine("Пт-рабочий");
}
if(a==6)
{
    Console.WriteLine("Сб-выходной");
}
if(a==7)
{
    Console.WriteLine("Вс-Выходной");
}

if(a>7)
{
    Console.WriteLine("Не день недели");
}