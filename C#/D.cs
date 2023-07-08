string[] stringArray = { "1", "2", "3", "4", "5" };
int[] intArray = Array.ConvertAll(stringArray, int.Parse);

Array.Reverse(intArray);

foreach (int number in intArray)
{
    Console.Write(number + " ");
}