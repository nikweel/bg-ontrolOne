//Метод запроса вводных
string ReadData(string line){
    Console.WriteLine(line);
    return Console.ReadLine();
}

//Метод приведения строки в массив по заданому разделителю и фильтрации не более 3 символов в элементах массива
string[] СonversionStrToArr(string line, string separator){
    string[] bufferArray = line.Split(separator);
    
    int i = 0;
    int j = 0;
    int resultArrayLength = 0;
    
    while (i < bufferArray.Length)
    {
        if(bufferArray[i].Length <= 3){
            resultArrayLength++;
        }
        i++;
    }
    
    string[] resultArray = new string[resultArrayLength];
    i = 0;
    while (i < bufferArray.Length)
    {
        if(bufferArray[i].Length <= 3){
            resultArray[j] = bufferArray[i];
            j++;
        }
        i++;
    }

    return resultArray;
}

//Метод печати одномерного массива
void PrintArray(string[] inputArray)
{
    int i = 0;
     Console.Write("[");
    while (i < inputArray.Length - 1)
    {
        Console.Write("\""+ inputArray[i] + "\"" + ",");
        i++;
    }
    Console.WriteLine("\""+ inputArray[i] + "\"" + "]");
}

Console.Clear();
string inputLine = ReadData("Введите элементы массива реазделяя их запятой");
PrintArray(СonversionStrToArr(inputLine, ","));