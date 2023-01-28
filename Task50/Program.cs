//я же правильно понял что массив должен сделать я сам в этой задаче?
using static System.Console;

int [,] array = getArray();
WriteLine($"Задан массив размером {array.GetLength(0)} на {array.GetLength(1)}");
printArray(array);
Write("Введите индекс массива через точку с запятой: ");
string [] index = ReadLine()!.Split(";", StringSplitOptions.RemoveEmptyEntries);
findNumber(array,index);

int [,] getArray()
{
    Random rnd = new Random();
    int [,] arr = new int [rnd.Next(3,7), rnd.Next(3,7)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(1,11);
        }
    }
    return arr;
}

void findNumber(int [,] arr, string [] ind)
{
    if (int.Parse(ind[0])>-1 && int.Parse(ind[1])>-1 && arr.GetLength(0)-1>=int.Parse(ind[0]) && arr.GetLength(1)-1>=int.Parse(ind[1]))
    {
        WriteLine($"{index[0]};{index[1]} = {arr[int.Parse(ind[0]),int.Parse(ind[1])]}");
    }
    else
    {
        WriteLine("Такого индекса в массиве нет");
    }

}

void printArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j],4}");
        }
        WriteLine("");
    }
}