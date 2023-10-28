/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/


/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

Random randomizer = new Random();
int[] numbers = new int[4];
int minRanomNumber = 0;
int maxRandoNUmber = 10;
//int result = 0;
int[] resultArray;

 for(int i = 0; i < numbers.Length; i++)
 {
    numbers[i] = randomizer.Next(minRanomNumber, maxRandoNUmber +1);
    Console.Write(numbers[i] + ",");
    
 }
Console.WriteLine();
if(numbers.Length % 2 == 0)
{
    resultArray = new int[numbers.Length / 2];
}
else
{
    resultArray = new int[numbers.Length / 2 + 1];
}

for(int i = 0; i < resultArray.Length; i++) // [1, 2, 3, 4, 5, 6] - 1*6, 2*5, 3*4
{
   
   resultArray[i] = numbers[i] * numbers[(numbers.Length - 1) - i];
   
}

if (resultArray.Length % 2 != 0)
   {
    resultArray[resultArray.Length - 1] = numbers[numbers.Length / 2]; 
   } 

for(int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + ", ");
}
Console.WriteLine();