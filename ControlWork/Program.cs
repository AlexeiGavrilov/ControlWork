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






































string[] StringArray = new string[] { "cat", "dog", "lesson", "snow", "son", "^_^", "(O_o)", "-10", "i5" };