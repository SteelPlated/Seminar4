﻿/*Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number<0) number=number*-1; //для того что отрицательные числа тоже считать

int FindNumberValue(int num)
{
    int div = 1;
    int count = 0;
    int num2 = 0;
    while (num > div)
    {
        num2 = num / div;
        div = div * 10;
        count++;
    }
    return count;
}
Console.WriteLine(FindNumberValue(number));

/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count=0;

while(num!=0)
{
    num=num/10;
    coun++;
}

Console.WriteLine(count);
*/