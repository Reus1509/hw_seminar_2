// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
double len = Math.Floor(Math.Log10(number) + 1);
int modul_arg = 10;
int del_arg = 10;
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
else if (len == 5){
    modul_arg *= 100;
    del_arg *= 10;   
}
else if (len == 6){
    modul_arg *= 1000;
    del_arg *= 100;
}
else if (len == 7){
    modul_arg *= 10000;
    del_arg *= 1000;
}
else if (len == 8){
    modul_arg *= 100000;
    del_arg *= 10000;
}
Console.WriteLine((number % modul_arg)/del_arg);