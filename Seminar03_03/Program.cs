// Программа - принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
int xA = Coordinate("x", "A");
int xA = Coordinate("y", "A");
int xA = Coordinate("x", "B");
int xA = Coordinate("y", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точка {pointName}");
    return Convert.ToInt16(Console.ReadLine());
}

/*Console.WriteLine("Введите координату x первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());

double a = (x2-x1)*(x2-x1); // Math.Pole - возвести в квадрат
double b = (y2-y1)*(y2-y1);
double c = a + b;
double distance = Gip(c);

double Gip(double sum)
{
    return  Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками равно {distance}");