// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] textArray = new string [4] {"1234", "1567", "-2", "computer science"};
int lenght = textArray.GetLength(0);
int resultArrayCount = 0;
string resultString = "[";
for (int i=0; i<lenght; i++)
{
    if (textArray[i].Length <= 3)
    {
        resultArrayCount++;
    }
    if (i+1 < lenght)
    {
        resultString += $"{textArray[i]}, ";
    }
    else
    {
        resultString += $"{textArray[i]}] -> [";
    }
}
string[] resultArray = new string[resultArrayCount];
resultArrayCount = 0;
for (int i=0; i < textArray.GetLength(0); i++)
{
        if (textArray[i].Length <= 3)
        {
            resultArray[resultArrayCount] = textArray[i];
            resultArrayCount++;
        }
}
for (int i=0; i < resultArray.GetLength(0); i++)
{
    if (i + 1 < lenght)
    {
     resultString += $"{resultArray[i]}] ";
    }
    else
    {
        resultString += $"{resultArray[i]}],";
    }
}
Console.Write(resultString); //вывод результата
