//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num_string = num.ToString();
char[] num_array = num_string.ToCharArray();

if (num > 99)
{
    Console.WriteLine($"Третья цифра: {num_array[2]}");
}
else
Console.WriteLine($"Третьей цифры нет!");
