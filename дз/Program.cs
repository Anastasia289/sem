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

/* // из массива удаляется элемент с позиции, которую введет пользователь


void FillArray ( int [] array, int length)
{
    int index = 0;
    while (index < length)
    {
        array [index] = new Random ().Next(-20, 20);  // заполнили массив и вывели массив
        Console.Write(array[index] + " ");
        index ++;
    }
}

void del ( int [] coll2, int y)
{
    for (int inde = 0; inde < coll2.Length; inde++) 
    {
        if (y> coll2.Length || y < 0)  
        {
            Console.WriteLine("Нет такой позиции"); 
            break;
        }
        if (inde != y) Console.Write(coll2[inde]+ " ");             
    }
} 

Console.WriteLine("Задайте длину массива");
int q = int.Parse(Console.ReadLine());
Console.WriteLine("C какой позиции элемент хотите убрать?");
int p = int.Parse(Console.ReadLine());
int [] w = new int [q];
FillArray (w, q);
Console.WriteLine();
del(w, p); */

/* // Создать массив из двух массивов

void FillArray ( int [] array, int length)
{
    int index = 0;
    while (index < length)
    {
        array [index] = new Random ().Next(-20, 20);  // заполнили  и вывели массив
        Console.Write(array[index] + " ");
        index ++;
    }
    Console.WriteLine();
}

void array (int [] array1, int [] array2)
{
    int length = array1.Length + array2.Length;
    int [] array3 = new int [length];
    for (int ind = 0; ind < array1.Length; ind++) 
    {
        array3[ind] = array1[ind];
        Console.Write(array3[ind]+ " ");
    }
    for (int ind2 = array1.Length; ind2 < length; ind2++) 
    {
        array3[ind2] = array2[ind2 - array1.Length];
        Console.Write(array3[ind2]+ " ");
    }
        
    }

Console.WriteLine("Задайте длину массива 1");
int l1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте длину массива 2");
int l2 = int.Parse(Console.ReadLine());
int [] arr1 = new int [l1];
int [] arr2 = new int [l2];
FillArray (arr1, l1);
FillArray (arr2, l2);
array(arr1, arr2); */