/* // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю
// строку массива.

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

void Transform (int [,] arr)
{
    
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
           int temp = arr[0,j];
           arr[0,j] = arr[arr.GetLength(0)-1,j];
           arr[arr.GetLength(0)-1,j] = temp;
        }
    }
}

Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine());
int [,] Arr = FillArr (a,b);
PrintArr (Arr);
Transform (Arr);
PrintArr (Arr); */

/* // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int [,] Transform (int [,] arr)
{
    int [,] arr1 = new int [arr.GetLength(1), arr.GetLength(0)];
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
           arr1[j,i] = arr[i,j];
        }
    }
    return arr1;
}

Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine());
int [,] Arr = FillArr (a,b);
PrintArr (Arr);
int [,] Arr2 = Transform (Arr);
PrintArr (Arr2); */

/*// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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

int [] Transform (int [,] arr)
{
    int [] arr1 = new int [arr.GetLength(1)* arr.GetLength(0)];
    int k = 0;
       for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
           arr1[k] = arr[i,j];
           k++;
        }
    }
    return arr1;
}
void PrintArr2 (int [] arr)
{
       for (int i=0; i<arr.Length; i++) Console.Write(arr[i] + " " );
  Console.WriteLine();
  Console.WriteLine();
}

int [] sort (int [] arr)
{
    int temp = 0;
    for (int i=0; i<arr.Length; i++)
    {
        for (int j=0; j<arr.Length; j++)
    {
        if (arr[i]<arr[j])
        {
            temp = arr[i];
            arr[i]= arr[j];
            arr[j] = temp;

        }
    }
    }
    return arr;
}

void FillDick (int[,] arr)
{
    Dictionary<int, int> numb = new Dictionary<int, int>();
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            if (numb.ContainsKey(arr[i,j])) numb[arr[i,j]]+=1;
            else numb.Add(arr[i,j],1);

        }
        
    }
foreach(var n in numb) Console.WriteLine($"Число{n.Key} встретилось {n.Value}");
}

int [,] CountVal (int[] ar)
{
    int leng = 1;
    for (int i=0; i<ar.Length-1; i++)
    {
        if (ar[i] != ar [i+1]) leng++;
    }
    int [,] NArr = new int [leng,2];
    NArr[0,0] = ar[0];
    int j = 0;

    for (int i=0; i<ar.Length; i++)
    {
     if (ar[i] == NArr[j,0])  NArr[j,1]++;
     else 
     {
       NArr[j+1,0] = ar[i];  // Почему-то во всех  столбцах кроме первого количество меньше на 1. вопрос, почему в первом не так
        j++; 
     }         
    }
return NArr;
}

Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine());
int [,] Arr = FillArr (a,b);
PrintArr (Arr);
int [] Arr2 = Transform (Arr);
sort (Arr2);
//FillDick (Arr);
PrintArr2 (Arr2);
int [,] Arr3 = CountVal(Arr2);
PrintArr (Arr3);*/

/*// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
PrintArr (Arr);*/

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 

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
Console.WriteLine($"Строка с наименьшей суммой элементов: {m}");*/

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 

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

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) 
// int [, ,] FillArr (int a, int b, int c) 

// {
//     int A = 10;
//    int [, ,] arr = new int [a,b,c];
//     for (int i=0; i<a; i++)
//     {
//         for (int j=0; j<b; j++)
//         {
//             for (int k=0; k<c; k++)
//         {
//             arr[i,j,k] = A;
//             A++;
//         }
//         }
//     }
// return arr;
// }

// int [, ,] FillArr (int a, int b, int c) 

// {
//    int [, ,] arr = new int [a,b,c];
//     for (int i=0; i<a; i++)
//     {
//         for (int j=0; j<b; j++)
//         {
//             for (int k=0; k<c; k++)
//         {
//             arr[i,j,k] = new Random().Next(1,9);
//         }
//         }
//     }
// return arr;
// }

// int [] TransArr (int [,,] arr)
// {
//     int [] a = new int [arr.GetLength(0)*arr.GetLength(1)*arr.GetLength(2)];
//     int ii = 0;

//     for (int i=0; i<arr.GetLength(0); i++)
//     {
//         for (int j=0; j<arr.GetLength(1); j++)
//         {
//             for (int k=0; k<arr.GetLength(2); k++)
//         {
//             a[ii] = arr[i,j,k];
//             Console.Write(a[ii] + " ");
//             ii++; 
//         }
//         }
//     } 
//     return a;
// }

// void CheckArr (int [] arr)
// {
//     int ii = 0;
//     int AA = arr[ii];
//     int count = 0;

//     for (int i=0; i<arr.Length; i++)
//     {       
//         if (arr[i] == arr[ii]) 
//         {arr[i] = new Random().Next(1,9);
//         count ++;
//         }
//     } 
//     Console.WriteLine();
// for (int i=0; i<arr.Length; i++) Console.Write(arr[i] + " " );
// Console.WriteLine();
// }

// void PrintArr (int [, ,] arr)
// {
//        for (int i=0; i<arr.GetLength(0); i++)
//     {
//         for (int j=0; j<arr.GetLength(1); j++)
//         {
//             for (int k=0; k<arr.GetLength(2); k++) Console.Write($" {arr[i,j,k]} ( {i}, {j}, {k}) " ); 
           
//         } 
//         Console.WriteLine();
//     }
//   Console.WriteLine();
// }

// Console.WriteLine("Задайте размер массива, введите 3 числа");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());
// int l = a*b*c;
// if (l>90) Console.WriteLine("двузначных чисел не хватит :(");
// int [, ,] arr1 = FillArr ( a,b,c);
// PrintArr (arr1); */

// //  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07 

// int [,] FillArr (int a) 

// {
//    int [,] arr = new int [a, a];
//    int aaa = 1;
//     for (int i=0; i<a; i++)
//     {
//         for (int j=0; j<a; j++)
//         {
//             if (i==0) { arr[i,j] = aaa; aaa++;} //вправо первая строка 

             
//         }

//         for (int j=0; j<a; j++)
//         {
           
//             if (arr[0,j]==a && i!=0) {arr[i,a-1] = aaa; aaa++;} //вниз

//         }
        
//         for (int j=a-1; j>=0; j--)
//         {
//             if (arr[a-1, a-1]!=0 && j!=a-1) {arr[a-1,j] = aaa; aaa++;} // влево
//         }
//          for (int j=a-1; j>=0; j--)
//         {
//             if (arr[a-1, 0]!= 0 && j !=a-1) 
//             {
//                 if (arr[j,0] == 0) {arr[j,0] = aaa; aaa++;}// вверх
                
//             } 
//         }
//           for (int j=1; j<a; j++)
//         {
           
//             if ( arr[j,j] == 0 && arr[j,j-1] != 0) 
//              {
//                 if (arr[i, j] == 0)

//                 {arr[i,j] = aaa; 
//                 aaa++;//вправо не первая
//                 }
            
//              }
//              if ( arr[j,j-1] == 0) continue; 

//         }



//     }
// return arr;
// }



// void PrintArr (int [,] arr)
// {
//        for (int i=0; i<arr.GetLength(0); i++)
//     {
//         for (int j=0; j<arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "  "); 
//         } 
//         Console.WriteLine();
//     }
//   Console.WriteLine();
// }

// Console.WriteLine("Задайте размер массива");
// int a = int.Parse(Console.ReadLine());
// int [,] arr1 = FillArr (a);
// PrintArr (arr1); 

// следующие не из дз - не дорешали на семинаре

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

// Это ДЗ к последнему семинару

/*// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
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
// Console.Clear();
// Console.Write("Введите N: ");
// int n =int.Parse(Console.ReadLine());
// Console.Write("Введите M: ");
// int m =int.Parse(Console.ReadLine());

// int FillNumbers(int N, int M){
//     if(N==M) return M;
//     if (N<M) return N + FillNumbers(N+1,M);
//     else
//          return (M + FillNumbers(M+1,N));
// }

// int A = FillNumbers (n,m);
// Console.WriteLine(A);
*/

/* // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 

//Даны два неотрицательных числа m и n. С помощью рекурсии!!!
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int wtf( int m, int n)
// {
// if (m == 0)
// {
// return n + 1;
// }
// else if ((m > 0) && (n == 0))
// {
// return wtf(m - 1, 1);
// }
// else if ((m > 0) && (n > 0))
// {
// return wtf(m - 1, wtf(m, n - 1));
// } else
// return n + 1;
// }

// Console.Write("Введите N: ");
// int n =int.Parse(Console.ReadLine());
// Console.Write("Введите M: ");
// int m =int.Parse(Console.ReadLine());
// int A = wtf (n,m);
//Console.WriteLine(A); */

/* //  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. попытка 2
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07 

// int [,] FillArr (int [,]aa)  //заполняет первую строку

// {
//     int a = aa.GetLength(0);
//    int [,] arr = new int [a, a];
//    int aaa = 1;
//     for (int i=0; i<a; i++)
//     {
//         for (int j=0; j<a; j++)
//         {
//             if (i==0) { arr[i,j] = aaa; aaa++;} //вправо первая строка  
//         } 
//     }
//     arr = Rotate(arr);
//      arr = Rotate(arr);
//      arr = Rotate(arr);

//      int l = arr.GetLength(0)/2;
//      if (arr[0,l]==0 ) arr= FillArr(arr);
   

// return arr;
// }



// int [,] Rotate(int[,] m) //переворачивает на 90 вправо
// {
//     var m2 = new int[m.GetLength(1), m.GetLength(0)];
 
//     for (int i = 0; i < m.GetLength(1); i++)
//         for (int j = 0; j < m.GetLength(0); j++)
//             m2[i, j] = m[m.GetLength(0) - j - 1, i];
 
//     return m2;
// }

// // int [,] FillArr2 (int [,] arr) //заполняет вторую и третью, почти периметр

// // {
     
// //     int i = 0;
// //     int aaa = arr[i,i]+1;
// //     int l = arr.GetLength(0)/2;
    
// //    if (arr[i,arr.GetLength(0)-1]==0)
// //     for (int j=0; j<arr.GetLength(0); j++)
// //     { 
// //            if (arr[i,j] == 0) 
// //            {arr[i,j] = aaa; 
// //             aaa++;  
// //            }
           
// //     }
// //      arr = Rotate(arr);
// //      arr = Rotate(arr);
// //      arr = Rotate(arr);
     
// //     if (arr[i+1,arr.GetLength(0)-1]==0) FillArr2 (arr) ;
   
// // return arr;
// // }

// int [,] FillArr2 (int [,] arr) //заполняет вторую и третью, почти периметр

// {
     
//     int i = 0;
//     int aaa = arr[i,i]+1;
//     int l = arr.GetLength(0)/2;
//     int j =0;
//     if ( j<4)
//     {
//         if (arr[i,l]==0 ) arr= FillArr(arr);
//         j++;
//     }
        
    
   
//     // for (int j=0; j<arr.GetLength(0); j++)
//     // { 
//     //        if (arr[i,j] == 0) 
//     //        {arr[i,j] = aaa; 
//     //         aaa++;  
//     //        }
           
//     // }
//     //  arr = Rotate(arr);
//     //  arr = Rotate(arr);
//     //  arr = Rotate(arr);
     
//     // if (arr[i+1,arr.GetLength(0)-1]==0) FillArr2 (arr) ;
   
// return arr;
// }


// void PrintArr (int [,] arr)
// {
//        for (int i=0; i<arr.GetLength(0); i++)
//     {
//         for (int j=0; j<arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "  "); 
//         } 
//         Console.WriteLine();
//     }
//   Console.WriteLine();
// }

// Console.WriteLine("Задайте размер массива");
// int a = int.Parse(Console.ReadLine());
// int [,] arr1 = new int [a, a];
// arr1 = FillArr (arr1);
// //arr1 = FillArr2 (arr1);
// // // PrintArr (arr1); 
// //FillArr3 (arr1);
// // PrintArr (arr1); 
// PrintArr (arr1); */