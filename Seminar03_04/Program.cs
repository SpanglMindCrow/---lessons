//После вода числа должно появится все числа в квадрате до заданного числа
// например, если 5 -> 1, 4, 9, 16, 25

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (N>=index)
{
    Console.Write($"{index*index} ");
    index++;
}



