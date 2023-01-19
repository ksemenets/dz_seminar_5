/*Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет количество
 чётных чисел в массиве.*/

 int[] GetRandomArray(int size, int leftRange, int rightRange)
 {
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
 }
 int[] massive = GetRandomArray(10, 100, 999);
 Console.WriteLine(String.Join(", ", massive));
 int result = 0;
 for(int i = 0; i < massive.Length; i ++)
    {
        if (massive[i] % 2 == 0)
            result ++;
    }
Console.WriteLine("Количество четных чисел в этом массиве = " + result);
