// задача по координатам x y , Вводишь номер четверти;
using static System.Console;
Clear();
Write("Введите число a:");
int a = Convert.ToInt32(ReadLine());

switch(a)
{
    case 1:
    {
        WriteLine("x>0 && y>0");
        break ;
    }        
    case 2:
    {
        WriteLine("x>0 && y<0");
        break;
    }
    case 3:
    {
        WriteLine("x<0 && y<0");
        break;
    }
    case 4:
    {
        WriteLine("x<0 && y>0");
        break;
    }
    default:
    {
        WriteLine("Это не номер четверти");
        break;
    }
}            