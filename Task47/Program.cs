using static System.Console;

Write("Введите размер массива, а также миниальное и максимальное числа через запятую: ");
string [] parametres = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);

double [,] getArray(int rows, int columns, double minValue, double maxValue)
{
    double delta = maxValue - minValue;
    double [,] array = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round((((new Random().NextDouble())+(minValue/delta))*delta),1);
        }
    }
    return array;
}