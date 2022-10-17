// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int [] FillArray()
{
    Console.WriteLine("введите длину массива");
    int L = int.Parse(Console.ReadLine());
    int [] qwerty = new int [L];
    int index = 0;
    while (index < qwerty.Length)
    {
        qwerty[index] = new Random ().Next(-10, 10); 
        index ++;
    }
    return qwerty;
}

void Printarr ( string [] array)
{
    int A = array.Length;
    int index = 0;
    while (index < A)
    {
        Console.Write(array[index] + " ");
        index ++;
    }
    Console.WriteLine();
}


void control(int[] array)
{
    Console.WriteLine();
    Console.Write("Введите число для поиска: ");
    int N = int.Parse(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == N)
        {
            count++;
        }
    }

    if (count > 0)
    {
        Console.Write($"Да, { count} раз");
    }
    else
    {
        Console.Write("Нет");
    }
}

