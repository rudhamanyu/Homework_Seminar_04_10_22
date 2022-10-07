/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void GetThirdDigit(int number)
{
    if (number > 99)
    {
        while (number > 999) 
            number = number / 10;
        int result = number % 10;
        Console.WriteLine($"Третья цифра: {result}");
    }
    else
        Console.WriteLine("Третьей цифры нет");
}
GetThirdDigit(12658);