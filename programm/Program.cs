void ArrWriter(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]},");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
    Console.Write("]");
}

string[] FindStringsInArray(string[] arr, int sizeString)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= sizeString) count++;
    }
    string[] resultArr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= sizeString)
        {
            resultArr[j] = arr[i];
            j++;
        }
    }

    return resultArr;
}
string[] arr = { "op", "Moscow", "56", "Podolsk", "opa" };

ArrWriter(arr);
Console.Write(" -> ");
ArrWriter(FindStringsInArray(arr, 3));
