// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.

Console.Clear();
float[] myArray = GetArrayFromUser("Введите длину массива: ", "Ошибка ввода");
float myDifference = MaxMinusMin(myArray);
ArrayPrint(myArray);
Console.Write($" -> {myDifference}");

float[] GetArrayFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userSize);
        if (isCorrect)
        {
            float[] array = new float[userSize];
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"Введите {index + 1} элемент массива: ");
                array[index] = float.Parse(Console.ReadLine());
            }
            return array;
        }
        Console.WriteLine(errorMessage);
    }
}

float MaxMinusMin(float[] array)
{
    float min = array[0];
    float max = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
        if (array[index] > max)
        {
            max = array[index];
        }
    }
    float difference = max - min;
    return (difference);
}

void ArrayPrint(float[] array)
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