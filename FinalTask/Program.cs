string[] array = new string[6] {"473", "-2", "hello", "world", "757t", ":-)"};
string[] result = new string[array.Length];


lengthOfArrayElements(array, result);
PrintArray(result);


void lengthOfArrayElements(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[count].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr3)
{
    arr3 = arr3.Where (x => !string.IsNullOrEmpty(x)).ToArray();
    for (int i = 0; i < arr3.Length; i++)
    {
        Console.Write($"\"{arr3[i]}\", ");
    }
    Console.WriteLine();
}