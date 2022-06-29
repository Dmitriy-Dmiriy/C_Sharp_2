// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа, или сообщает что третьей цифры нет.

int FindThirdDigit(int num)
{
int third = 0;
if (num >= 100)
          {
    while ( num >= 1000)
             {
                num = num / 10;
             }
        third = num %10;
          }
    else 
          {
             return -1;
          }
    return third;

}
Console.Write("Введите число -> ");
int n = Convert.ToInt32(Console.ReadLine());
int th = FindThirdDigit(n);
Console.WriteLine("Третья цифра -> " + th);
