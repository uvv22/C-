using System;
using static System.Console;

Clear();
WriteLine("Введите через пробел массив: ");
int[] array = GetArrayFromString(ReadLine());

int[] outArray = GetResultArray(array);
WriteLine(String.Join(" ", outArray));





int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int[] GetResultArray(int[] inArray)
{
    int size = inArray.Length / 2;
    if (inArray.Length % 2 == 1) size++;

    int[] result = new int[size];

    for (int i = 0; i < inArray.Length / 2; i++)
    {
        result[i] = inArray[i] * inArray[inArray.Length - 1 - i];
    }

    if (inArray.Length % 2 == 1) result[size - 1] = inArray[inArray.Length / 2];
    return result;
}