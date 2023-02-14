/*4. Напишите программу, которая будет выдавать название дня недели по заданному номеру.*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num > 7 || num < 1)
Console.WriteLine("Число должно быть от 1 до 7.");
else
switch (num)
{
    case 1:
        Console.WriteLine("Понедельник.");
        break;
    case 2:
        Console.WriteLine("Вторник.");
        break;
    case 3:
        Console.WriteLine("Среда.");
        break;
    case 4:
        Console.WriteLine("Четверг.");
        break;
    case 5:
        Console.WriteLine("Пятница.");
        break;
    case 6:
        Console.WriteLine("Суббота.");
        break;
    case 7:
        Console.WriteLine("Воскресенье.");
        break;
}