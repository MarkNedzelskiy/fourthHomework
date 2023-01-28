/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int InputNumber() 
{
    
    Console.WriteLine("Введите число: ");
    
    int inputNumber;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out inputNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы должны ввести число! Попробуйте снова: ");
        }
    }

    return inputNumber;
}

int CountDigitsInNumber(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    }

    return summ;
}

int number = InputNumber();
int digitsSumm = CountDigitsInNumber(number);
Console.WriteLine(digitsSumm);

