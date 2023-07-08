int[] SelectNumbers(int[] array, int limit)
{
    int[] selectedNumbers = new int[array.Length];
    int count = 0;

    foreach (int number in array)
    {
        if (number > limit)
        {
            selectedNumbers[count] = number;
            count++;
        }
    }

    Array.Resize(ref selectedNumbers, count);
    return selectedNumbers;
}
int[] array = { 1, 2, -5, 8, -3, 9, -7 };
int limit = 4;

int[] result = SelectNumbers(array, limit);


for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i]);
    if (i != result.Length - 1)
    {
        Console.Write(", ");
    }
}
