﻿// Напишите, программу, которая принимает на вход два числа и выдает какое чило большее, а какое меньшее 
// а = 5, b = 7 -> max = 7
// а = 2, b = 10 -> max = 7
// а = -9, b = -3 -> max = 7


int max = 0;
int min = 0;
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);