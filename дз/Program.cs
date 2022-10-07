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

// void c (int x, int y)
// {
//     if (x>0 && y>0) Console.WriteLine("jj");
//     else if (x>0 && y<0) Console.WriteLine("jjj");
//     else if (x<0 && y<0) Console.WriteLine("jjjd");
//     else  Console.WriteLine("jjjkk");

// }

// string cc2 (int x, int y) {
//     string nn = x > 0 && y >0 ? "1 cha" : "nope";
//     return nn;
// }
// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());
// c(x,y);
// string ccdd = cc2(x, y);
// Console.WriteLine(ccdd);

// string aa (int aa)
// {
//     string name = a == 1 ? "x= (o, +inf), y = (0, +inf)" : aa == 2  ? 
//     "x= (-inf, 0), y = (0, +inf)" : aa == 3 ? "x= (- inf, 0), y = (0, -inf)" : aa == 4 ? "x= (o, +inf), y = (0, -inf)" : aa == 2 : "нет такой";
//     return name; 
// }

// int aaa = int.Parse(Console.ReadLine());
// string jj = aa(aaa);
// Console.WriteLine(jj)

// // Выводит все элементы массива пока не встретится элемент -1

// int q = int.Parse(Console.ReadLine());
// int [] a = new int[q];
// void FillArray( int length, int [] col)
// {
//     int index = 0;
//     while (index < length)
//     {
//         col[index] = new Random ().Next(-3, 4); 
//         index ++;
//     }
// }

// void PrintArray( int [] coll)
// {
//     int count = coll.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(coll[position]+ " "); 
//         position ++;
//     }
// }

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


string chetvert (int a)
{
    string name = a == 1 ? "x= (o, +inf), y = (0, +inf)" : a == 2  ? 
    "x= (-inf, 0), y = (0, +inf)" : a == 3 ? 
    "x= (- inf, 0), y = (0, -inf)" : a == 4 ? 
    "x= (o, +inf), y = (0, -inf)" : "нет такой четверти";
    return name; 
}
Console.WriteLine("Введите четверть");
int a = int.Parse(Console.ReadLine());
string otvet = chetvert(a);
Console.WriteLine(otvet);


