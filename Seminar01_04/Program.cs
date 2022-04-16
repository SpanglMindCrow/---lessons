Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA - (numberA * 2);

while (numberB <= numberA )
{
    Console.Write(numberB + ", ");
    numberB++;
}