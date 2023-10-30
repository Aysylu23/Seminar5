/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


Random randomizer = new Random();
int minRandomNumber = 1;
int maxRandomNumber = 10;
int sizeArray = 6;
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
for(int i = 1; i < numbers.Length; i+=2)
{
    sum = sum + numbers[i];

}

Console.Write(sum + " ");
