// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна 
// -20.


string SummOfNumbers()
{
    int[] arr = new int[12];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
    }

    int sumPositive = 0;
    int sumNegative = 0;
    
    for (int j = 0; j < arr.Length; j++)
    {
    if (arr[j] > 0)
    {
        sumPositive += arr[j];
    }

    else
    {
        sumNegative += arr[j];
    }
    }

    string output = $"You array: {String.Join(", ", arr)}\nSumm of positive numbers of array is {sumPositive}\nSumm of positive numbers of array is {sumNegative}";;

    return output;
}

System.Console.WriteLine(SummOfNumbers());
// void SumOfNumbers(){

//     int[] PrintArray()
//     {
//         int[] array2 = new int[12];
//         for (int i = 0; i < 12; i++)
//         {
//             array2[i] = new Random().Next(-9, 9);
//             Console.Write($"{array2[i]} ");
//         }
//         Console.WriteLine();
//         return array2;

//         PrintArray();


//         int sumPositive, sumNegative;

//         for (int j = 0; j < 12; j++)
//         {
//             if (array2[j] > 0)
//             {
//                 sumPositive += array2[j];
//             }
//             else
//             {
//                 sumNegative += array2[i];
//             }
//         }
//     }
// }
// Console.WriteLine(sumNegative());
// Console.WriteLine(sumPositive());
