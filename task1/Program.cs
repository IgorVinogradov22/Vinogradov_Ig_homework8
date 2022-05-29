// Задайть двумерный массив. Написать программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите число строк массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива ");
int b = Convert.ToInt32(Console.ReadLine());

//Создать двумерный массив. 

int[,] Create(int a, int b)
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }

    }
    return arr;

}

//Вывод массива в консоль.

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//сортировка элементов массива.

void SelectionSort(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int min = j;

            for (int k = j + 1; k < array.GetLength(1); k++)
            {

                if (array[i, k] < array[i, j])
                {
                    min = k;
                    int temp = array[i, j];
                    array[i, j] = array[i, min];
                    array[i, min] = temp;
                }
            }
        }
    }
}

//Вывод массива в консоль.

void PrintSelect(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}


int[,] inArr = Create(a, b);
PrintArr(inArr);
SelectionSort(inArr);
PrintSelect(inArr);
