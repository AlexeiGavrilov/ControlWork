int CheckTheString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void CreateArrayCorrectElements(string[] array1, string[] array2)
{
    int k = 0;
    for (int i = 0; i < array1.Length; i++)
    {

        if (array1[i].Length <= 3)
        {
            array2[k] = array1[i];
            k++;
        }


    }
}

void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

string[] StringArray = new string[] { "cat", "dog", "lesson", "snow", "son", "^_^", "(O_o)", "-10", "i5" };

string[] FinalArray = new string[CheckTheString(StringArray)];

CreateArrayCorrectElements(StringArray, FinalArray);

PrintStringArray(FinalArray);