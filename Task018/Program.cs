// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

if(num == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if(num == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if(num == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if(num == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Введите значение от 1 до 4");
}

//---------------------------

Console.Write("Введите номер четверти, по которой хотите получить координаты: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:
    {
       Console.WriteLine("В первой четверти значения х > 0, y > 0");
       break; 
    }
    case 2:
    {
        Console.WriteLine("В первой четверти значения х < 0, y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("В первой четверти значения х < 0, y < 0");
        break;
    }
    case 4:
    {
       Console.WriteLine("В первой четверти значения х > 0, y < 0");
       break;
    }
    
    default:
    {
        Console.WriteLine("Значение не верное");
        break; 
    }
}