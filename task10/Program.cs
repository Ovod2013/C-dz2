// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число");
int a=int.Parse(Console.ReadLine()!);
int chislo=Prow3znaka(a);



int Prow3znaka(int arg)
{
if (100>arg || arg>999)
{
    return (0);
}

else return (arg);
}

if (chislo != 0)
{
Console.Write("Вторая цифра этого числа ");

Console.Write((chislo - chislo%10 - (chislo/100)*100)/10);
}
else 
Console.WriteLine("Это не трёхзначное число: ");