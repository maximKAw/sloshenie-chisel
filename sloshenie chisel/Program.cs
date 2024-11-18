using System;

public class Calculator
{
    // Публичный метод для сложения двух чисел
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Приватный метод для проверки, является ли число четным
    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Метод для демонстрации использования приватного метода
    public void CheckEven(int number)
    {
        if (IsEven(number))
        {
            Console.WriteLine($"{number} - четное число.");
        }
        else
        {
            Console.WriteLine($"{number} - нечетное число.");
        }
    }

    // Метод Main для запуска программы
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // Пример сложения двух чисел
        int sum = calculator.Add(5, 10);
        Console.WriteLine($"Сумма: {sum}");

        // Проверка на четность
        calculator.CheckEven(4);
        calculator.CheckEven(7);
    }
}