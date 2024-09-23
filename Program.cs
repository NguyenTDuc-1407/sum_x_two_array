const int x = 3, y = 3;
int sum = 0;
int[,] arr = new int[x, y] {
                { 3, 2, 1 },
                { 4, 2, 3 },
                { 5, 1, 6 }
            };

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (i == j)
        {
            sum = sum + arr[i, j];
        }
    }
}
Console.Write("Tong cac phan tu tren duong cheo chinh la: {0}\n", sum);
