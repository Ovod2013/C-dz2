// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7:");
string str1 = Console.ReadLine()!;
int a=int.Parse(str1);//Превращение строки в число
string chislo=ProwSbVs(a);
Console.WriteLine(chislo);

string ProwSbVs(int arg)// Проверка на наличие трёх и более знаков
{
if (arg==7 || arg==6)
{
    return ("Да");
}
else return ("Нет");
}
