//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

int[] CreateArr(int arrLen)
{
    int[] array = new int[arrLen];
    for (int i = 0; i < arrLen; i++)
    {
        array[i] = new System.Random().Next(100,999);
    }
    return array;
}

int NumberOfEvenNumbers(int[] arr)
{
    int result =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) result++;
    }
    return result;
}

void PrintData(string msg, int value, string msg2)
{
    Console.WriteLine(msg + value + msg2);
}
int arrLen = ReadData("Введите длину массива: ");
int[] arr = CreateArr(arrLen);
void Print1DArr(int[] arr)
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
PrintData("В вашем массиве " , NumberOfEvenNumbers(arr), " четных чисел" );
