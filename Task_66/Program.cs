/**
* * Задача 66
*   Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*
*   M = 1; N = 15 -> 120
*   M = 4; N = 8. -> 30
*
*/

/// Получение целочисленного значения от пользователя с консоли.
///     message - сообщение, выводимое пользователю
int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

/// Рекурсивный расчет суммы чисел в заданном диапазоне. 
///     startNumber - стартовое число
///     endNumber - финишное число
int GetNumbersSum(int startNumber, int endNumber)
{
    if (startNumber == endNumber)
    {
        return endNumber;
    }

    if (startNumber < endNumber)
    {
        return startNumber + GetNumbersSum(startNumber + 1, endNumber);
    }

    return startNumber + GetNumbersSum(startNumber - 1, endNumber);
}


/// Main body.
/// Допустимы только натуральные числа
int startNumber = InputInt("Input start number: ");
int endNumber = InputInt("Input end number: ");

if (startNumber <= 0 || endNumber <= 0)
{
    Console.WriteLine("You have to use only natural numbers!");
}
else
{
    Console.WriteLine(GetNumbersSum(startNumber, endNumber).ToString());
}