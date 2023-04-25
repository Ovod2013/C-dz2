// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
//Console.Write("Введите трёхзначное число: ");
//int a=int.Parse(Console.ReadLine()!);


Console.WriteLine("введите число:");
//$чисел: {Console.ReadLine().Length};
//int k=Length;
string str1 = Console.ReadLine()!;
//int v1 = str1.Length;
Console.WriteLine(str1);

//Console.WriteLine($"чисел: {Console.ReadLine().Length}");
//Console.WriteLine(
//string str1 = "Hello";
int v1 = str1.Length;
Console.WriteLine(v1); // v1 = 5


int a=123;

int chislo=Prow3znaka(a);



int Prow3znaka(int arg)
{
if (100>arg)
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
Console.WriteLine("Третьей цифры нет");
