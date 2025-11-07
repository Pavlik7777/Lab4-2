//двумерные массивы 
Console.WriteLine("Введите n:");
Console.WriteLine("Введите y:");
Random rnd = new Random();
int n = rnd.Next();
int y = rnd.Next();
int[,] mas = new int[n, y];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i] = new int[rnd.Next(10, 100)];
        Console.Write($"{mas[i][j]} ");

        }
    Console.WriteLine();
}
int min = mas[0][0];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] < min) min = mas[i][j];
    }
}
int row = -1;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] < min)
        {
            min == mas[i][j];
            row = i;
            break;
        }
        if (row != -1) break;
    }
}
for (int j = 0; j < mas.GetLength(1); j++)
{
    mas[row + 1, j] = mas[0, j];
}
Console.WriteLine();