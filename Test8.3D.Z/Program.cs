// Задача 15 на день недели и выходной(если пятидневка)
using static System.Console;
Clear();
Write("Введите число a : ");
int a = Convert.ToInt32(ReadLine());
switch(a)
{
    case 1:
    {
        WriteLine("рабочий");
        break ;
    }        
    case 2:
    {
        WriteLine("рабочий");
        break;
    }
    case 3:
    {
        WriteLine("рабочий");
        break;
    }
    case 4:
    {
        WriteLine("рабочий");
        break;
    }
    case 5:
    {
        WriteLine("рабочий");
        break;
    }
    case 6:
    {
        WriteLine("выходной");
        break;
    }
    case 7:
    {
        WriteLine("выходной");
        break;
    }
    default:
    {
        WriteLine("Это не день недели");
        break;
    }
}    