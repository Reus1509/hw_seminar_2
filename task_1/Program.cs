// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

//Проверка на трехзначное число.
if (number < -999 || number > -100 && number < 100 || number > 999 )
{
    Console.WriteLine("Вы ввели не трёхзначное число!");
}
//Если отрицательное число.
else if(number < 0){
    int otr_number = number*(-1);
    int result = (otr_number%100/10);
    Console.WriteLine($"Вторая цифра числа {number} -> {result}.");
}
else
{
  int result = number%100/10;
  Console.WriteLine($"Вторая цифра числа {number} -> {result}.");
}