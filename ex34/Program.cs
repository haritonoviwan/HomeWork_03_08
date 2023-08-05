// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

Console.Clear();
int[] myArray = GetArray("Введите длину массива: ", "Ошибка ввода");
int evenNumbers = QuantityOfEvenNumbers(myArray);
ArrayPrint(myArray);
Console.WriteLine($" -> {evenNumbers}");

int[] GetArray(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userSize);
        if (isCorrect)
        {
            int[] array = new int[userSize];
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = new Random().Next(100, 1000);
            }
            return array;
        }
        Console.WriteLine(errorMessage);
    }
}

int QuantityOfEvenNumbers(int[] array)
{
    int counter = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length; index++)
    {
        if (index < array.Length - 1)
        {
            Console.Write($"{array[index]}, ");
        }
        else
        {
            Console.Write(array[index]);
        }
    }
    Console.Write("]");
}