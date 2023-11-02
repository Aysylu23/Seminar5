/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Random randomizer = new Random();
int minRandomNumber = 100;
int maxRandomNumber = 999;
int[] numbers = new int[5];
int count = 0;


for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minRandomNumber, maxRandomNumber + 1);
    Console.Write(numbers[i] + " ");
    
    if(numbers[i] % 2 == 0)
    {
        count++;
    }   
}
Console.Write($"-> {count}");