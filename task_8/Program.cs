﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите любое целое число: ");          //Запрашиваем данные.
string num = Console.ReadLine()!.Trim();               //Вводим число.
while(num == "")                                       //Проверяем что пользователь не забыл ввести данные
{                                                      //или не нажал пробел.
    Console.Write("Введите любое целое число: ");      //Снова запрашиваем данные.
    num = Console.ReadLine()!.Trim();                  //Снова пытаемся ввести число.
}
int number = int.Parse(num);                           //Парсим строку в инт
int result;                                            //Создаём переменную для записи чётных чисел.

for (int i = 1; i <= number; i++)                      //Создаём цикл с количеством итераций равным вводимому числу.
{
    if (i % 2 == 0)                                    //В цикле при каждой итерации проверяем значение счётчика на деление без остатка.
    {
        result = i;                                    //Если значение счётчика делится на 2 без остатка то записываем его в переменную result.
        Console.Write($"{result}, ");                  //При каждой итерации и выполнении условия if выводим результат на кансоль.
    }
}
