if (magazine.Length < 3)
{
    indexes = new int[magazine.Length];
    for (int i = 0; i < magazine.Length; i++)
    {
        indexes[i] = i;
    }
}
else
{
    int z = magazine[0] + magazine[1] + magazine[2];
    indexes = new int[] { 0, 1, 2 };   // первая тройка уже считается лучшей
    for (int i = 1; i < magazine.Length - 2; i++)
    {
        int zd = magazine[i] + magazine[i + 1] + magazine[i + 2];
        if (zd > z)
        {
            z = zd;
            for (int j = 0; j < 3; j++)
            {
                indexes[j] = i + j;
            }
        }
    }
}
