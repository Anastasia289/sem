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

/* // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] Fillsmth ()

{
    Console.WriteLine("Cколько чисел будем вводить?");
    int M = int.Parse(Console.ReadLine());
    int [] a = new int [M];
    Console.Write("Введите число ");
    for (int i = 0; i <M; i++)
    {
        a[i] = int.Parse(Console.ReadLine());    
    }
    return a;
}

void Countpos (int [] arr)
{
   int n = 0;
   for (int i = 0; i <arr.Length; i++)
    {
    if (arr[i] > 0) n++;
    Console.Write(arr[i] + " ");
    }
    
    Console.WriteLine($"Количество положительных чисел равно {n}"); 
}
int [] aaa = Fillsmth ();
Countpos (aaa); */

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите k и b для первой прямой");
// int k1 = int.Parse(Console.ReadLine());
// int b1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите k и b для второй прямой");
// int k2 = int.Parse(Console.ReadLine());
// int b2 = int.Parse(Console.ReadLine());

// if (k1 == k2) 
// {
//     if (b1==b2) 
//     Console.WriteLine("Они совпадают"); 
//     else Console.WriteLine("Они параллельны"); 
// }
// double x01 = b2-b1;
// double x02 = k1-k2;
// double x03 = x01/x02;
// //double x0 = (b2-b1)/(k1-k2); // я хз что не так, но считает неправильно. 
// double y0 = x03*k1+b1;
// double y1 = x03*k2+b2;

// Console.WriteLine($"Точка пересечения: х = {x03}, у = {y0}");

/* //  Заполнить двумерный массив следующим образом. Вводится число n.

int n = int.Parse(Console.ReadLine());
int [,] m = new int [n,n];

for (int i = 0; i<m.GetLength(0); i++)
{
        for (int j = 0; j<m.GetLength(1); j++)
    {
        
        if (i>=j) m[i,j] = j+1;
        else   m[i,j] = i+1;     
        Console.Write(m[i,j] + " ");
    }
    Console.WriteLine();
} */

 /* // Дано действительное положительное число a и целое неотрицательное число n. Вычислите an не используя циклы, 
// возведение в степень через ** и функцию math.pow(), а используя рекуррентное соотношение an=a⋅an-1.
// Решение оформите в виде функции power(a, n).


double power( double a, int n )
{
  
if(n == 1) return a;
else return a * power( a, n-1 );
}

Console.WriteLine("Введите число и степень, в которую его нужно возвести");
double num = int.Parse(Console.ReadLine());
int step = int.Parse(Console.ReadLine());
if (step <0) Console.WriteLine("Упс");
double dd = power(num, step);
Console.WriteLine(dd); */
