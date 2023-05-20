//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();

Console.Write("Введите первое число для сравнения: ");
int number1 = int.Parse(Console.ReadLine());//Вводим первое число

Console.Write("Введите второе число для сравнения: ");
int number2 = int.Parse(Console.ReadLine());//Вводим второе число

if(number1 > number2)  //Сравниваем числа
{
    Console.WriteLine($"Число {number1} > числа {number2}");  //Выводим результат если number1 > number2
}
else
{
    if(number1 < number2)
    {
        Console.WriteLine($"Число {number1} < числа {number2}"); //Иначе если number1 < number2 выводим другой результат
    }
    else
    {
        Console.WriteLine($"Число {number1} = числу {number2}"); //Иначе если оба условия не выполняются выводим что числа равны
    }
}
