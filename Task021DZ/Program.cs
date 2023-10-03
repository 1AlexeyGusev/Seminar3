// //Задача 21: Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координаты Х, точки А: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Y, точки А: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Z, точки А: ");
// int z1 = int.Parse(Console.ReadLine());

// Console.Write("Введите координаты Х, точки B: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Y, точки B: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Z, точки B: ");
// int z2 = int.Parse(Console.ReadLine());

// double c = Math.Sqrt (Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

// System.Console.WriteLine($"Расстояние между координатами: {c}");

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
      double distance = 0.0;
      for (int i = 0; i < 3; i++) {
        double dx = (pointA[i] - pointB[i]);
        distance += dx * dx;
      }
      return Math.Sqrt(distance);

      }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 10;
            x2 = 6;
            x3 = 8;
            y1 = 21;
            y2 = 10;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}