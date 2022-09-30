// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
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
        array[i] = new System.Random().Next(0,9);
    }
    return array;
}

int SumOfOddNumbers(int[] arr)
{
    int result =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2==1) result =result + arr[i];
    }
    return result;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
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
PrintData("Сумма элементов, стоящих на нечетных позициях равна : " , SumOfOddNumbers(arr));