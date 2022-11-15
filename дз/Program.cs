// Семинар 8

/* // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2 

int [,] FillArr (int a, int b)
{
    int [,] arr = new int [a,b];
    for (int i=0; i<a; i++)
    {
        for (int j=0; j<b; j++)
        {
            arr[i,j] = new Random().Next(1,9);
        }
    }
return arr;
}

void PrintArr (int [,] arr)
{
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " " );
        }
        Console.WriteLine();
    }
  Console.WriteLine();
}

void Sortarr (int [,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
           int minind = j; 
           for (int ii = j; ii < arr.GetLength(1); ii++) 
        {
            if (arr[i,ii] < arr[i,minind])
            {
                minind = ii; 
            }
        }     
            
         int temp = arr[i,j]; 
         arr[i,j] = arr[i,minind]; 
         arr[i,minind] = temp; 
        }
        
    }
}

Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine());
int [,] Arr = FillArr (a,b);
PrintArr (Arr);
Sortarr (Arr);
PrintArr (Arr); */

/* // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 

int [,] FillArr (int a)
{
    int [,] arr = new int [a,a];
    for (int i=0; i<a; i++)
    {
        for (int j=0; j<a; j++)
        {
            arr[i,j] = new Random().Next(1,9);
        }
    }
return arr;
}

void PrintArr (int [,] arr)
{
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " " );
        }
        Console.WriteLine();
    }
  Console.WriteLine();
}

int [] CountMiddl (int [,] arr) 
{
   int [] temp = new int [arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++) 
    {
       int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            sum += arr[i,j];
        }
        temp[i] = sum;
        
    }
    return temp;
}

void PrintArr2 (int [] arr)
{
       for (int i=0; i<arr.Length; i++) Console.Write(arr[i] + " " );
  Console.WriteLine();
  Console.WriteLine();
}

int FindMin (int [] ar)
{
    int min = ar[0];
    int minind = 0;
    for (int i=0; i<ar.Length; i++) 
    {
        if (ar[i] < min) 
        {
            min = ar[i];
            minind = i;
        }

    }
return minind;
}

Console.WriteLine("размер массива?");
int a = int.Parse(Console.ReadLine());
int [,] Arr = FillArr (a);
PrintArr (Arr);
int [] arr2 = CountMiddl(Arr);
PrintArr2 (arr2);
int m = FindMin (arr2)+1;
Console.WriteLine($"Строка с наименьшей суммой элементов: {m}"); */

/* // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18 

int [,] FillArr (int a, int b)
{
    int [,] arr = new int [a,b];
    for (int i=0; i<a; i++)
    {
        for (int j=0; j<b; j++)
        {
            arr[i,j] = new Random().Next(1,9);
        }
    }
return arr;
}

void PrintArr (int [,] arr)
{
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " " );
        }
        Console.WriteLine();
    }
  Console.WriteLine();
}

int [,] MultArr (int [,] a, int [,] b)
{
    int [,] arr = new int [a.GetLength(0),b.GetLength(1)];
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<b.GetLength(1); j++)
        {
           for (int k=0; k<b.GetLength(0); k++)
           {
            arr[i,j] += a[i,k]*b[k,j];
            //r[i,j] += a[i,k] * b[k,j];
           }
        }
    }
return arr;
}

Console.WriteLine("Введите количество строк для матрицы 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы 1");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы 2");
int c = int.Parse(Console.ReadLine());

int [,] arr1 = FillArr ( a,b);
int [,] arr2 = FillArr ( b,c);
PrintArr (arr1);
PrintArr (arr2);
int[,] arr3 = MultArr (arr1, arr2);
PrintArr (arr3); */

/* // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1) 
int [, ,] FillArr (int a, int b, int c) 

{
    int A = 10;
   int [, ,] arr = new int [a,b,c];
    for (int i=0; i<a; i++)
    {
        for (int j=0; j<b; j++)
        {
            for (int k=0; k<c; k++)
        {
            arr[i,j,k] = A;
            A++;
        }
        }
    }
return arr;
}

void PrintArr (int [, ,] arr)
{
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            for (int k=0; k<arr.GetLength(2); k++) Console.Write($" {arr[i,j,k]} ( {i}, {j}, {k}) " ); 
           
        } 
        Console.WriteLine();
    }
  Console.WriteLine();
}

Console.WriteLine("Задайте размер массива, введите 3 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int l = a*b*c;
if (l>90) Console.WriteLine("двузначных чисел не хватит :(");
int [, ,] arr1 = FillArr ( a,b,c);
PrintArr (arr1); */

/* //  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void FillArr (int [,] arr) 
{
   int l = arr.GetLength(0)/2;
   if ((arr.GetLength(0) % 2) == 1) l++;


   int aaa = arr[0,0] + 1;
   int a = arr.GetLength(0);
   for (int k=0; k<l; k++)
    for (int i=0; i<a; i++)
    {
        for (int j=0; j<a; j++)
            {
                if (arr[k,j] ==0 ) { arr[k,j] = aaa;  aaa++;}  //вправо
            }    

        for (int j=0; j<a; j++)
           
             {
                if (arr[j,a-1-k] == 0) {arr[j,a-1-k] = aaa; aaa++;}// вниз
             }
        
        for (int j=a-1; j>=0; j--)
           if (arr[a-1-k,j] ==0 ) { arr[a-1-k,j] = aaa;  aaa++;}  //влево
        
         for (int j=a-1; j>=0; j--)
        {
            if (arr[a-1, k]!= 0 && j !=a-1) 
            {
                if (arr[j,k] == 0) {arr[j,k] = aaa; aaa++;}// вверх   
            } 
        }
        
    }

}



void PrintArr (int [,] arr)
{
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "  "); 
        } 
        Console.WriteLine();
    }
  Console.WriteLine();
}

Console.WriteLine("Задайте размер массива");
int a = int.Parse(Console.ReadLine());
int [,] arr1 = new int [a, a];
FillArr (arr1);
PrintArr (arr1);  */

// Семинар 9

/* // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите N: ");
int n=int.Parse(Console.ReadLine());

// цифры от 1 до N
string PrintNumbers(int N)
{
    if (N==1) return N.ToString();
    return (N + " " + PrintNumbers(N-1));
}

Console.WriteLine(PrintNumbers(n)); */

/* // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N. С помощью рекурсии!!!
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите N: ");
int n =int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m =int.Parse(Console.ReadLine());

int FillNumbers(int N, int M){
    if(N==M) return M;
    if (N<M) return N + FillNumbers(N+1,M);
    else
         return (M + FillNumbers(M+1,N));
}

int A = FillNumbers (n,m);
Console.WriteLine(A); */


 // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 

//Даны два неотрицательных числа m и n. С помощью рекурсии!!!
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int wtf( int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if ((m > 0) && (n == 0))
{
return wtf(m - 1, 1);
}
else if ((m > 0) && (n > 0))
{
return wtf(m - 1, wtf(m, n - 1));
} else
return n + 1;
}

Console.Write("Введите N: ");
int n =int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m =int.Parse(Console.ReadLine());
int A = wtf (n,m);
Console.WriteLine(A); 
