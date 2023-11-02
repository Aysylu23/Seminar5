/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


/*Random randomizer = new Random();
double minRandomNumber = 0;
double maxRandomNumber = 10;
int sizeArray = 4;
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.NextDouble(minRandomNumber, maxRandomNumber);
}

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

double maxNumber = numbers[0];
double minNumber = numbers[0];

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    } 
    
    if(minNumber > numbers[i]) 
    {
        minNumber = numbers[i];
    }
    
}      


double result = maxNumber - minNumber;

Console.Write(result);*/


Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

Random rand = new Random();
for (int i = 0; i < a; i++)
{
    randomArray[i] = rand.NextDouble();
    Console.Write($"{randomArray[i]:F2}");

}

double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
    {
        if (max<randomArray[i])
        {
            max = randomArray[i];
        }
        if (min>randomArray[i])
        {
            min = randomArray[i];
        }
i = i + 1;
}
    return max-min;

double result = max - min;
Console.Write($"Разница между максимальным и минимальным элементов массива: {result:F2}");
