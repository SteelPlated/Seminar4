/*Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 1;
// int SummNumber(num)
//{
// int summ =1;
for (int i = 1; i <= num; i++)
{
    sum = sum * i;
}
//   return summ;
//}

// int result = SummNumber(num);
Console.WriteLine($"Произведение чисел от 1 до {num} ={sum}");
