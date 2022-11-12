/* 
// int [,] m1 =
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int number = int.Parse(Console.ReadLine());
string number2 = Convert.ToString(number, 2);
Console.WriteLine(number2);

string perevod (int number, int osn)
{
    string res = "";
    string nums = "0123456789abcdef";
    while (number >0)
    {
        int del = number/osn;
        res = nums[number -del*osn] + res;
        number/=osn;
    }
    return res;
}

perevod(6,2);
Console.WriteLine(number2); */

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с 
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());
// int number3 = int.Parse(Console.ReadLine());

// if ((number1>= number2 +number3) || (number2>= number1 +number3) || (number3>= number1 +number2)) Console.WriteLine("нет");
// else Console.WriteLine("все ок"); 


 // Дано нечетное число n. Создайте двумерный массив из n×n элементов, заполнив его символами "." (каждый элемент 
// массива является строкой из одного символа). Затем заполните символами "*" среднюю строку массива, 
// средний столбец массива, главную диагональ и побочную диагональ. В результате единицы в массиве должны 
// образовывать изображение звездочки. Выведите полученный массив на экран, разделяя элементы массива пробелами.

int n = int.Parse(Console.ReadLine());
string [,] m = new string [n,n];
int k = n/2;

for (int i = 0; i<m.GetLength(0); i++)
{
    for (int j = 0; j<m.GetLength(1); j++)
    {
        m[i,j] = ".";
        //Console.Write(m[i,j]);       
    }
    //Console.WriteLine();
}
//int u = n;
for (int i = 0; i<m.GetLength(0); i++)
{
    
    for (int j = 0; j<m.GetLength(1); j++)
    {
       
        if (j == k) m[i,j] = "*";
        if (i == k) m[i,j] = "*";
        m[i,i] = "*";
        m[i,n-i-1] = "*"; 
       Console.Write(m[i,j] + " "); 
              
    }
    Console.WriteLine();
} 

// Дано число n. Создайте массив размером n×n и заполните его по следующему правилу.
//  На главной диагонали должны быть записаны числа 0. На двух диагоналях, прилегающих к главной, числа 1.
//   На следующих двух диагоналях числа 2, и т.д.

int n = int.Parse(Console.ReadLine());
int [,] m = new int [n,n];
int cc = 1;

for (int i = 0; i<m.GetLength(0); i++)
{
        for (int j = 0; j<m.GetLength(1); j++)
    {
        
        if (i==j) m[i,j] = 0;
        else if (j>i) 
        {
           cc = j-i;
           m[i,j] = cc;
           
        }
        m[j,i] = m[i,j];
       
        Console.Write(m[i,j] + " ");
    }
    Console.WriteLine();
}
