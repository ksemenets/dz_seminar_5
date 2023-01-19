/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    } 
    return array;
}
int[] massiv = GetRandomArray(15, 1, 20);
Console.WriteLine(String.Join(", ", massiv));
int summa = 0;
for(int i = 1; i < massiv.Length; i = i +2)
summa = summa + massiv[i];
Console.WriteLine("Сумма всех искомых элементов = " + summa);