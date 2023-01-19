/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
*/

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    } 
    return array;
}
int[] massiv = GetRandomArray(12, 1, 20);
Console.WriteLine(String.Join(", ", massiv));
int max = massiv[0];
int min = massiv[0];
for(int i = 0; i < massiv.Length; i ++)
    {
        if (massiv[i] > max)
            max = massiv[i];
        else
            if(massiv[i] < min)
            min = massiv[i];        
    }  
int dif = max - min;         
Console.WriteLine($"Максимальный элемент = {max}");
Console.WriteLine($"Минимальныйьный элемент = {min}");
Console.WriteLine($"Разница между ними = {dif}");