/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

void GetNumber(int number)
{
    int secondDigit = number % 100 / 10;
    Console.WriteLine($"{number} -> {secondDigit}");
}

GetNumber(861);