// на вход два числа и проверяет , является ли одно число квадратом другого.
// 5, 25 -> да
using static System.Console;
Clear();

void CheckMultiple(int number1, int number2)
{
   if (number2 == number1 * number1)
   {
      Console.WriteLine("Yes");
   } 
   else
   {
      Console.WriteLine("No");
   }
}
Console.WriteLine("Inter number1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter number2:");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 < number2)
{
    CheckMultiple(number1, number2);
}
else
{
    CheckMultiple(number2, number2);
}