int a = new Random().Next(10, 100);
Console.WriteLine(a);
int first = a / 10;
int second = a % 10;

int max = Max(first, second);
Console.WriteLine(max);

int Max(int a1, int a2)
{
    if (a1 > a2)
        return a1;

    return a2;
}