
int[] array = { 1, 5, 8, 5, 3, 9 };
int value = 5;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == value)
    {
        count++;
    }
}

Console.WriteLine(count);
