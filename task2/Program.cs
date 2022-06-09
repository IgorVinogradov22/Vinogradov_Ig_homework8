//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
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

//Вычисление минимальной суммы элементов массива в каждой строке отдельно.

void SumElements(int[,] arr)
{
     
     int [] res = new int [a]; 
         
     int sum = 0;

    for (int i = 0; i < res.Length; i++)
    {
        for (int j = 0; j < res.Length; j++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{sum} {"строка"} {i},{' '}");

        res[i] = sum;

        sum = 0;
    }
  
    for (int i = 0; i < res.Length - 1;)
    {
        int min = i;

        for (int j = i + 1; j < res.Length; j++)
        {
            if (res[j] < res[min])
            {
                res[min] = res[j];
                min = j;
            }
        }
        Console.Write($"{"min сумма"} {res[min]} {"строка"} {min}");
        break;
    }
}   

int[,] arr = Create(a, b);
PrintArr(arr);
SumElements(arr);



