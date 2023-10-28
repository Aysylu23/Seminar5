Random randomizer = new Random();
int minRandomNumber = -9;
int maxRandomNumber = 9;
int sizeArray = 12;
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

int positiveSum = 0;
int negativeSum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
        positiveSum += numbers[i];
    else
        negativeSum += numbers[i];
}

Console.WriteLine($"Сумма положительных равна {positiveSum}, сумма отрицательных равна {negativeSum}");
