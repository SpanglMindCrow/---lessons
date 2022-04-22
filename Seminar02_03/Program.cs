Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваши числа - " + number1 + " и " + number2);

void Result (int a1, int a2)
{
    int divA = a1 % a2;
    if (divA == 0)
    {
        Console.WriteLine("Кратные числа");
    }
    else
    {
        Console.WriteLine("Числа не кратны. Остаток -" +  divA);
    }
}
Result (number1, number2);