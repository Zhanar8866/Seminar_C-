// Задача №10. Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа

int number = new Random().Next(100,1000);
Console.WriteLine(number);

int number1 = number % 1000/100; // формула для поиска первой цифры из остатка (1000 / 100 = 10, т.е. первая цифра остатка)
Console.WriteLine(number1);

int number3 = number%10;
Console.WriteLine(number3);

Console.Write(number1);
Console.WriteLine(number3);

/* второй способ решения - вместо команд, начиная с 6-строки "int number1 = number % 1000/100;"

string newNumber = "";
newNumber += number % 1000/100;
newNumber += number % 10;
Console.WriteLine(newNumber);
*/