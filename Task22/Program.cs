/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125*/
//23 = a * a * a
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] res = new int[num];
int j = 0;
for (int i = 1; i <= num; i++)
{
    res[j] = i * i * i;
    Console.Write($"{res[j]}, ");
    j++;
}

