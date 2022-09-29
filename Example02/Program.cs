
int[] CreatArr(int size)
{
    int [] array = new int [size]; // задаем новый массив
    for (int i = 0; i < array.Length; i++) // заполняем массив рандом числами от -10 до 11
    {
        array [i] = new Random().Next(-10,11);
    }
    return array;
}
int[] NumberArr (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;  // делает цифры другим знаком
    }
    return array;
}
bool FindNumber(int number, int[] array) //  проверяет есть ли 1 в массиве
{
    //foreach (var item in array)
    //{
        //if(item == number) 
       // {
            //return true;
        //}
    //}
    //return false;
    return array.Contains(number); //  проверяет есть ли 1 в массиве только без цикла (поиск элементов)
}


int [] array = CreatArr(8);
System.Console.WriteLine(string.Join(" ", array));
array = NumberArr(array);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(FindNumber(1,array));