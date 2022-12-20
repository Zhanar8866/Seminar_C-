// Найти наибольшую цифра случайного числа из отрезка [10,99]

int number = new Random().Next(10,100);
Console.WriteLine(number);

if(number/10 > number%10)
{
    Console.WriteLine(number/10);
}
else
{
    Console.WriteLine(number%10);
}
