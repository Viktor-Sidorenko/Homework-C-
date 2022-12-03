int number = new Random().Next(1,10);
Console.WriteLine(number);

int count = 2;
while (number >= count)
{
    Console.WriteLine(count);
    count = count + 2;
}
