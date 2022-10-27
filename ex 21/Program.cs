Console.WriteLine("Write x");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write y");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write z");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write x");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write y");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write z");
double z2 = Convert.ToDouble(Console.ReadLine());

double x = x2 - x1;
double y = y2 - y1;
double z = z2 - z1;

double result = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2)+Math.Pow(z, 2));

Console.WriteLine(result);


