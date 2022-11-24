// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string array = Console.ReadLine();
int num = Convert.ToInt32(array);

if(num < 100)
{
    Console.WriteLine("Отсутствует третья цифра");
}
else
{
    Console.WriteLine(array[2]);
}