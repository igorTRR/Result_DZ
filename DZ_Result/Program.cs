 

// // написать программу,которая из имеющегося массива строк формирует
// //массив из строк, длина которого меньше либо ровна 3 символам.


string[] StartArray = new string[5] {"hello", "Res", "Test ", "DZ", "Yes"};
string[] FinishArray = new string[StartArray.Length];
void MediaArray(string[] StartArray, string[] FinishArray)
{
    int count = 0;
    for (int i = 0; i < StartArray.Length; i++)
    {
    if(StartArray[i].Length <= 3)
        {
        FinishArray[count] = StartArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
MediaArray(StartArray, FinishArray);
PrintArray(FinishArray);
