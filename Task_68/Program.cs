/**
* * Задача 68
*
*   Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*
*   m = 2, n = 3 -> A(m,n) = 9
*   m = 3, n = 2 -> A(m,n) = 29
*
*/

/// Получение целочисленного значения от пользователя с консоли.
///     message - сообщение, выводимое пользователю
int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

/// Вычисление функции Аккермана.
///     numberM - число m функции A(m, n)
///     numberN - число n функции A(m, n)
int AkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }

    if (numberM > 0 && numberN == 0)
    {
        return AkkermanFunction(numberM - 1, 1);
    }

    return AkkermanFunction(numberM - 1, AkkermanFunction(numberM, numberN - 1));
}


/// Main body.
int numberM = InputInt("Input m: ");
int numberN = InputInt("Input n: ");

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Numbers must be more than 0!");
}
else
{
    Console.WriteLine($"A(m, n) = {AkkermanFunction(numberM, numberN)}");
}