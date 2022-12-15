Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());

if ((x > 0) && (y > 0))
Console.WriteLine("Первая четверть");
if ((x > 0) && (y < 0))
Console.WriteLine("Четвёртая четверть");
if ((x < 0) && (y > 0))
Console.WriteLine("Вторая четверть");
if ((x < 0) && (y < 0))
Console.WriteLine("Первая четверть");