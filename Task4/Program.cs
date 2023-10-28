/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Random randomizer = new Random();
int minRandomNumber = 1;
int maxRandomNumber = 100;
int rangeMin = 10;
int rangeMax = 99;
int sizeArray = 10;
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minRandomNumber, maxRandomNumber + 1);
}

WriteIntArray(numbers);

int count = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] >= rangeMin && numbers[i] <= rangeMax)
        count++;
}

Console.WriteLine(count);


void WriteIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}