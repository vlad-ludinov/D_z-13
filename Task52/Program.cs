using static System.Console;



int [,] getArray()
{
    Random rnd = new Random();
    int [,] array = new int [rnd.Next(3,7), rnd.Next(3,7)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,11);
        }
    }
    return array;
}

double [] findAverage(int [,] array);
{
    double [] average = new double [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        average[i] = sum / array.GetLength(0);
    }
    return average;
}