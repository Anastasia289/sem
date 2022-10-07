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





