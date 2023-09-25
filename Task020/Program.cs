// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты Х, точки А: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y, точки А: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Х, точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y, точки B: ");
int y2 = int.Parse(Console.ReadLine());

double c = Math.Sqrt (Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

System.Console.WriteLine($"Расстояние между координатами: {c}");