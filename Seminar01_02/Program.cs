Console.WriteLine("Введите перовое чило: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberA * numberA;

if (square == numberB)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Неть, первое число не является квадратом второго");
}
