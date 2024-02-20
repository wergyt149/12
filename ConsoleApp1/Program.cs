using System;

class Program
{
    static void Main()
    {
        int a, b, d;

        //Ввод значения a с клавиатуры
        Console.Write("Введите значение a: ");
        if (int.TryParse(Console.ReadLine(), out a))
        {
            //Ввод значения b с клавиатуры
            Console.Write("Введите значение b: ");
            if (int.TryParse(Console.ReadLine(), out b))
            {
                //Ввод значения d с клавиатуры
                Console.Write("Введите значение d: ");
                if (int.TryParse(Console.ReadLine(), out d))
                {
                    int c = a / b + d; //Вычисляем частное a и b плюс d

                    //Проверка, содержит ли a, b, d или c число 5
                    if (ContainsFive(a) || ContainsFive(b) || ContainsFive(d) || ContainsFive(c))
                    {
                        Console.WriteLine("Как так-то, а?");
                    }
                    else
                    {
                        Console.WriteLine("Результат деления a и b плюс d: " + c);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка при вводе d. Введите целое число.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка при вводе b. Введите целое число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка при вводе a. Введите целое число.");
        }
    }

    // Функция для проверки, содержит ли число 5
    static bool ContainsFive(int number)
    {
        return number.ToString().Contains("5");
    }
}

