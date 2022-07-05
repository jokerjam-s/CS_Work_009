/**
* * Задача 64
*   Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
*
*   N = 5 -> "5, 4, 3, 2, 1"
*   N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*
*/

/// Получение целочисленного значения от пользователя с консоли.
///     message - сообщение, выводимое пользователю
int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

/// Рекурсивный вывод чисел от N до 1.
///     startNumber - стартовое число для вывода
string GetNumbersLine(int startNumber)
{
    if (startNumber == 1)
    {
        return "1";
    }

    return startNumber.ToString() + ", " + GetNumbersLine(startNumber - 1);
}


int startNumber = InputInt("Input number: ");

if (startNumber <= 0)
{
    Console.WriteLine("Number must be more than 0!");
}
else
{
    Console.WriteLine(GetNumbersLine(startNumber));
}

