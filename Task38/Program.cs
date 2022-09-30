//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

double[] CreateArr(int arrLen)
{
    double[] array = new double[arrLen];
    Random rand = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        array[i] = rand.Next(-99, 99) + rand.NextDouble();
    }
    return array;
}

double NumberOfEvenNumbers(double[] arr)
{
    double result =0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        
        if(arr[i] < min) min = arr[i];
        if(arr[i] > max) max = arr[i];
    }
    //System.Console.WriteLine(min);
    //System.Console.WriteLine(max);
    result = max-min;
    return result;
}

void PrintData(string msg, double value)
{
    Console.WriteLine(msg + value);
}
int arrLen = ReadData("Введите длину массива: ");
double[] arr = CreateArr(arrLen);
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
Print1DArr(arr);
System.Console.WriteLine();
PrintData("Разница между максимальным и минимальным значениями массива равна: " , NumberOfEvenNumbers(arr));
