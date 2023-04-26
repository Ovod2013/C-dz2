// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число не более 10 разрядов:");
string str1 = Console.ReadLine()!;

int razr = str1.Length;
Console.WriteLine("В этом числе " + razr + " разряда(-ов)"); // v1 = 5

int a=int.Parse(str1);

int chislo=ProwBolee3znakov(a);



int ProwBolee3znakov(int arg)// Проверка на наличие трёх и более знаков
{
if (arg<100)
{
    return (0);
}
else return (arg);
}

if (chislo != 0)// Вычисление третьей цифры
{
Console.Write("Третья цифра этого числа ");
//Console.WriteLine("РРР" +razr);//контроль количества разрядов
int star = chislo/(Stepen(10,(razr-2)))*(Stepen(10,(razr-2)));
//Console.WriteLine("Старшая часть числа" + star);
int mlad = chislo%(Stepen(10,(razr-3)));
//Console.WriteLine("Младшая часть числа" + mlad);
Console.Write((chislo - mlad - star)/(Stepen(10,(razr-3))));
}
else 
Console.WriteLine("Третьей цифры нет");

int Stepen (int v1, int v2)// Вычисление v1 в степени V2, v1^v2
{
    int k=0,b=1;
    while(k!=v2)
    {
        k++;
        b *=v1;
    }
//    Console.WriteLine("степень" + b);//контроль вычисления степени
    return(b);
}