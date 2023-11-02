/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


Random randomizer = new Random();
int minRandomNumber = 1;
int maxRandomNumber = 10;
int sizeArray = 5;
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minRandomNumber, maxRandomNumber + 1);
}

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
Console.Write(sum + " ");
