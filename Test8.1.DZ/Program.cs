// Вывести , какое число больше : а или b;
using static System.Console;
Clear();
Write("Введите число a: ");
int  a = Convert.ToInt32(ReadLine());
Write("Введите число b: ");
int b = Convert.ToInt32(ReadLine()); 
string answer = a > b ? "a > b": a < b ? "a < b":  "a равно b";

if(a>b)
{
    answer="a>b";
}
else
if(a<b)
{
    answer="a<b";
}
else
{
    answer="a=b";
}
WriteLine(answer);

