/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет;
*/

void DayWeek(int number)
{
    if (number > 0 && number < 8)
    {
        if (number < 6)
            Console.WriteLine("Будний день");
        else
            Console.WriteLine("Выходной день");
    }
    else
        Console.WriteLine("Число не соответвует дню недели");
}

DayWeek(7);