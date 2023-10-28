/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[]numbers = {-4, -8, 8, 2};

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + ",");
   
}

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
    Console.Write(numbers[i] + ",");
} 
