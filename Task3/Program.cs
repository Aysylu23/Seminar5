/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] numbers = {6, 7, 19, 345, -3};

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
bool ok = false;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == number)
    {
        
        ok = true;
        break;
    }        
       
}
 if(!ok)
 {
    Console.WriteLine("Отсутствует");
 }
 else
 {
    Console.WriteLine("Присутствует");
 }



 /*Random randomizer = new Random();
int minRandomNumber = -9;
int maxRandomNumber = 9;
int sizeArray = 4;
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minRandomNumber, maxRandomNumber + 1);
}

WriteIntArray(numbers);

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == number)
    {
        Console.WriteLine("Yes");
        return;
    }
}
Console.WriteLine("No");


void WriteIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}*/

/*Random randomizer = new Random();
int minRandomNumber = -9;
int maxRandomNumber = 9;
int sizeArray = 4;
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minRandomNumber, maxRandomNumber + 1);
}

WriteIntArray(numbers);

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
bool result = false;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == number)
    {
        result = true;
        break;
    }
}
if(result)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


void WriteIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}*/