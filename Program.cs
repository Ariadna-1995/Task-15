//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if(num == 6 || num == 7)
{
    Console.Write($"Это выходной день");
}
else if(num>0 && num<6)
{
    Console.Write($"Это будний день");
}
else
{
    Console.Write($"Попробуйте ввести номер недели ещё раз");
}