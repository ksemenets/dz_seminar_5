/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
 Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. */

int[] GetRandomArray(int size, int leftRange, int rightRange)// объявили метод, который формирует массив из случайных чисел
{
    int[] array = new int [size];
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }    
    return array;
}
int[] massive = GetRandomArray(20, 0, 20); //вызвали метод, объявленный ранее (20 элементов от 0 до 20)
Console.WriteLine(String.Join(", ", massive));//вывели в консоли сформированный выше массив в виде строки
int poisk(int A, int B) // объявили метод, который может искать в массиве числа в заданном пользователем 
                        //интервале и подсчитывает их количество
{    
    int n = 0;
    for(int i = 0; i < massive.Length; i ++) //этот цикл перебирает по одному все элементы массива
    {
        if(massive[i] >= A && massive[i] <= B) //здесь проверяем элементы на соответствие условию
        
            n = n + 1; //и суммируем количество элементов, отвечающих условию
    }   

          return n; 
}
Console.WriteLine("Введите нижнюю границу поиска");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу поиска");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Искомых элементов " + poisk(A, B));/*выводим в консоль сообщение с количеством
 искомых элементов, при этом в этой же строке вызываем метод poisk. Т.о. наше сообщение содержит 
 в себе результаты работы этого метода */
