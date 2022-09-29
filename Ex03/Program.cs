// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreatArr(int size)
{
    int [] array = new int [size]; // задаем новый массив
    for (int i = 0; i < array.Length; i++) // заполняем массив рандом числами от -10 до 11
    {
        array [i] = new Random().Next(-10,11);
    }
    return array;
}
int Summ (int [] array)
{
    int sum = 0;
    for (int i = 10; i < 99; i++)
    {
        sum++;
    }
    return sum;
}

int [] array = CreatArr(123);
int su = Summ(array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(su);

