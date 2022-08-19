// задача по координатам 
using static System.Console;
Clear();
Write("Введите число x:");
int x = Convert.ToInt32(ReadLine());
Write("Введите y:");
int y = Convert.ToInt32(ReadLine());
if(x>0 && y>0)
{
    Write("первая четверть");
}
if(x>0 && y<0)
{
    Write("Вторая четверть");
}
if(x<0 && y<0)
{
    Write("Третья четверть");
}
if(x<0 && y>0)
{
   Write("Четвёртая");
}