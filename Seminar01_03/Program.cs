Console.WriteLine("Введите номер дня: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 7)
{
    Console.WriteLine("У тебя беды с башкой, такого дня недели нет");
}

if (numberA < 0)
{
    Console.WriteLine("Ты шутишь? В таком случае шутки, у тебя не смешные. Не пиши сюда больше.");
}

if (numberA == 1)
{
Console.WriteLine("Понедельник");
}
    
if (numberA == 2)
{
Console.WriteLine("Вторник");
}
    
if (numberA == 3)
{
Console.WriteLine("Среда");
}
    
if (numberA == 4)
{
Console.WriteLine("Четверг-это маленькая пятница");
}
    
if (numberA == 5)
{
Console.WriteLine("Пятница-можно закупаться пивом=)");
}
    
if (numberA == 6)
{
Console.WriteLine("Суббота-ыремя для чила");
}
    
if (numberA == 7)
{
Console.WriteLine("Воскресенье-мажь жопу вазелином, завтра понедельник");
}