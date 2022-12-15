Console.WriteLine("Введите координату x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками = " + Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2)));

