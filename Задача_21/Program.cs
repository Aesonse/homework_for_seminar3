//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите координаты двух точек: \nx1: \ny1: \nz1: \nx2: \ny2: \nz2: ");
double[] coordinates = new double[6];

for (int i = 0; i < 6; i++)
{
    Console.SetCursorPosition(4, i + 1);
    coordinates[i] = double.Parse(Console.ReadLine()); 
}

double x1 = coordinates[0], y1 = coordinates[1], z1 = coordinates[2],
x2 = coordinates[3], y2 = coordinates[4], z2 = coordinates[5];

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Расстояние между ними в 3D пространстве {d:f2}");