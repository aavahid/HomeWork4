void MyFunction(int[] intArray, bool[] boolArray)
{
    int minLength = int.Min(intArray.Length, boolArray.Length);
    int result = 1;

    for (int i = 0; i < minLength; i++)
    {
        if (boolArray[i])
        {
            result *= intArray[i];
        }
    }

    Console.WriteLine(result);
}



    int[] array1 = { 6,4,7,2, };
    bool[] array2 = { false, true, true, true };

MyFunction(array1, array2);
