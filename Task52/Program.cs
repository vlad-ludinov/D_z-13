using static System.Console;

WriteLine("Задан массив: ");
int [,] array = getArray();
printArray(array);
double [] averageColumns = findAverage(array);
WriteLine($"Среднее арифметическое столбцов: {String.Join("; ",averageColumns)}");


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


double [] findAverage(int [,] arr)
{
    double [] average = new double [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += Convert.ToDouble(arr[j,i]);
        }
        average[i] = Math.Round((sum/ arr.GetLength(0)),1);
    }
    return average;
}

void printArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i,j],4}");            
        }
        WriteLine("");
    }
}
