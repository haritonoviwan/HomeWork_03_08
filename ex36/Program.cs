// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

Console.Clear();
int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода");
int minValue = GetNumberFromUser("Введите минимальное число: ", "Ошибка ввода");
int maxValue = GetNumberFromUser("Введите максимальное число: ", "Ошибка ввода");
int[] myArray = GetArray(length, minValue, maxValue);
int mySum = SumElementsInOddPositions(myArray);
ArrayPrint(myArray);
Console.WriteLine($" -> {mySum}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumElementsInOddPositions(int[] array)
{
int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (index % 2 == 0) // делится без остатка на два, т. к. у элементов на нечетных позициях четный индекс
        {
            sum = sum + myArray[index];
        }
    }
    return sum;
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