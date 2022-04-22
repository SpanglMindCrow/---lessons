int a = RandomInt(100, 1000);
Console.WriteLine(a);
int number1 = a/100;
int number2 = a%10;

Console.Write(number1);
Console.Write(number2);

int RandomInt(int min, int max)
{
    return new Random().Next(min, max);
}