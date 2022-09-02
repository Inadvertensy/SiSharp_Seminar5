string SummOfNumbers()
{
    int[] array = new int[12];

    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);

        if (array[i] > 0)
    {
        sumPositive += array[i];
    }

    else
    {
        sumNegative += array[i];
    }
    }

    string output = $"You array: {String.Join(", ", array)}\nSumm of positive numbers of array is {sumPositive}\nSumm of positive numbers of array is {sumNegative}";;

    return output;
}

System.Console.WriteLine(SummOfNumbers());