/* // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random ().Next(100, 999);
Console.WriteLine(num);
int a1 = num/10;
int a2 = a1%10;

Console.WriteLine(a2); */

/* // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a = new Random ().Next(1, 9999999);
Console.WriteLine(a);

void tr (int num)
{
    if (num < 99) Console.WriteLine("Третьей цифры нет");
int find = 0;
while ( num/1000 >0)
{
    num = num/10;
    find = num%10;
       
}
Console.WriteLine(find);
}

tr(a); */

/* // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет 

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

if (n > 7) n = n%7; // перейдем на другую неделю
if (n < 1) Console.WriteLine("Такого дня нет");
if (n < 6) Console.WriteLine("Не выходной");
if (n > 5) Console.WriteLine("Выходной"); */

/* // Дан список чисел, необходимо удалить все вхождения числа 20 из него и вывести его в обратном порядке. 

int [] a = new int[15];
void FillArray( int [] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random ().Next(19, 25); 
        index ++;
    }
}

void PrintArray( int [] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(coll[position]+ " "); 
        position ++;
    }
}

FillArray(a);
PrintArray(a);

void Pr( int [] aaa)
{
    int c = aaa.Length -1;
    int pos = c;
    while (pos > -1)
    {
        if (aaa[pos] != 20) Console.Write(aaa[pos]+ " "); 
        pos --;
    }
}
Console.WriteLine();
Pr(a); */

/* // Вводится строка слов, разделенных пробелами. Найти самое длинное слово и вывести его на экран.
 
Console.WriteLine("Введите предложение");
string str = Console.ReadLine();
string [] word = str.Split(' ');
int x = word.Length;
int [] aaa = new int [x]; 
int i = 0;
string j = " ";
int a = 0;

 for (i = 0; i < x; i++)
{
    j = word[i];
    a = j.Length;
    aaa[i] = a;  
}

int max = aaa[0];
int ii = 0;
 for (ii = 0; ii < x; ii++)
{
    if (aaa[ii] > max) max = aaa[ii];   
  
}

int Index(int [] aaa, int find)
{
    int count = aaa.Length;
    int index = 0;
    int position = -1; // 
    while(index < count)
    {
        
        if (aaa[index] == find) 
        {
            position = index;
        }
        index++;
    }
    return position;
}
int pos = Index(aaa, max);

Console.WriteLine(word[pos]); */

/* //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int polindrom (int a)
{
    if (a %10 == a/10000%10 && a/10%10 == a/1000 %10) Console.WriteLine("да");
    else Console.WriteLine("нет");
    return a; 

}

int num = new Random ().Next(10000, 99999);
Console.WriteLine(num);

int e = 34543; // полиндром, чтобы убедиться, что "да" работает

polindrom(num);
polindrom(e); */


/* // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

void distance (int x1, int y1, int z1, int x2,  int y2, int z2)
{
    double d = Math.Sqrt(Math.Pow (x2- x1, 2) + Math.Pow (y2- y1, 2) + Math.Pow (z2- z1, 2 ));
    Console.WriteLine(d);
}

Console.WriteLine("Введите координаты точки А");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между точками равно ");
distance(ax, ay, az, bx , by, bz); */

/* // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void kub (int a)
{
   double [] axz = new double [a+1];
   for (int i = 1; i <= a; i++)
{
    axz [i] = Math.Pow(i, 3);
    Console.Write(axz [i] + " ");
}
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
kub (num); */

// из массива удаляется элемент с позиции, которую введет пользователь


int [] FillArray ( int length)
{
    int [] col = new int [length];
    int index = 0;
    while (index < length)
    {
        col[index] = new Random ().Next(-20, 20);  // задали и заполнили массив
        Console.Write(col[index] + " ");
        index ++;
        
    }
    return col;
}

int [] del ( int [] coll2, int y)

{
    int [] coll3 = new int [coll2.Length];
    if (y> coll2.Length || y < 0) Console.WriteLine("Нет такой позиции"); 
    for (int index2 = 0; index2 < coll2.Length; index2++) 
          
    {
        if (index2 != y) coll3[index2] = coll2[index2];
        Console.Write(coll3[y]+ " "); 
        index2++;
    }
    return index2;
} 

Console.WriteLine("Задайте длину массива");
int q = int.Parse(Console.ReadLine());
Console.WriteLine("C какой позиции элемент хотите убрать?");
int p = int.Parse(Console.ReadLine());

int [] w = FillArray(q);
Console.WriteLine();
del(w, p);


//del(im, p);

// int fill (int [] coll3)
// {
//     int x = 0;
            
//     while (x < coll3.Length)
//     {
        
//         if (coll3[x] == -1) break;
//         x++;
           
//     }
//     return x;
// } 

// void PrintArray2 ( int [] coll, int len)
// {
//     int pos = 0;
//     while (pos < len)
//     {
//         Console.Write(coll[pos]+ " "); 
//         pos ++;
//     }
// }
// FillArray(q,a);
// PrintArray(a);
// Console.WriteLine();
// //filtrarray (a);
// int index2 = fill(a);
// PrintArray2(a, index2);