/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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

while (true)
{
    int firstNumber = InputNumber();
    int secondNumber = InputNumber();
    Console.WriteLine(Math.Pow(firstNumber, secondNumber));
}