// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
double len = Math.Floor(Math.Log10(number) + 1);
double modul_arg = 10;
double del_arg = 10;
if(len < 3){
    Console.WriteLine("Третьей цифры нет!");
    return;
}
if(len == 3)
{
    Console.WriteLine(number % modul_arg);
    return;
}
else if (len == 4){
    modul_arg *= 10;
}
else if (len >= 5){
    modul_arg *= Math.Pow(10, len-3);
    del_arg *= Math.Pow(10, len-4);   
}
Console.WriteLine((number % (int)modul_arg)/(int)del_arg);