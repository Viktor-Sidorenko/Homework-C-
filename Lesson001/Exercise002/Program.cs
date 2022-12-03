int number = new Random().Next(1,10);
Console.WriteLine(number);
double result = number % 2;
if (result == 0) 
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}