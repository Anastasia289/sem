/* //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > number1) max = number2;
Console.WriteLine(max);
    Console.Write("число 1 = " + number1 + " число 2 = " + number2 + " максимум = " + max); */
    
/* //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* // Максимум из трех
Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.Write("число 1 = " + number1 + " число 2 = " + number2 + " число 3 = " + number3 + " максимум = " + max); */

/* // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number %2 ==0) Console.Write("да");
else Console.WriteLine("нет"); */

/* // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number);
int i = 0;
while (i< number)
{
    i+=2;
    Console.Write(i + " ");
}
*/

/* // Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19. 


Console.WriteLine("Введите длину массива");
int lenght = int.Parse(Console.ReadLine());
int[] numbers = new int [lenght];
var i=0;
for (i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1,20);
    Console.Write(numbers[i] + " ");   //создали массив, заполнили его случайными числами от 1 до 20 и вывели на экран для наглядности
}
Console.WriteLine("Введите номер элемента");
int k = int.Parse(Console.ReadLine());
if (k > lenght) Console.WriteLine("Неверное значениею. Введите число не больше  " + lenght); // убедились что номер элемента подходит

var j = 0;
for (i = 0; i < k; i++)
{
    j = j + numbers[i];// посчитали первую часть
     
}
var g = 0;
for (i = k; i< lenght; i++)
{
    g = g + numbers[i]; // посчитали вторую часть
     
}

Console.WriteLine(j);
Console.WriteLine(g); // вывели на экран, чтобы было видно что сравниваем и была возможность себя проверить
if (j > g) Console.WriteLine("Первая часть");
if (j == g) Console.WriteLine("ничья");
else Console.WriteLine("Вторая часть"); //тадам! */

/* // посчитать сумму цифр числа, например 246 будет 12

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int sum = 0;
int temp = 0;
while ( number != 0)
{
    temp = number%10;
    sum = sum + temp;
   number = number/10;
}
Console.WriteLine(sum); */

/* // Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.

int num = new Random ().Next(1, 9999);
Console.WriteLine(num);

int max = 0;
int temp = 0;
while ( num != 0)
{
    temp = num%10;
    if (temp>max) max = temp;
   num = num/10;
}
Console.WriteLine(max); */

/* // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random ().Next(1, 999);
Console.WriteLine(num);
int a1 = num/100;
int a2 = num%10;
int a3 = a1*10 +a2;
Console.WriteLine(a3); */

/* //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());
int num3 = num1%num2;
if (num3 ==0) Console.Write("кратно");
else Console.WriteLine("не кратно, остаток  " + num3); */

/* // Найти два наименьших положительных(минимальных) элемента массива

int [] array = new int [10];  
void FillArray( int [] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random ().Next(-10, 100); // заполнить массив случайными числами
        index ++;
    }
}

void PrintArray( int [] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(coll[position]+ " "); // вывести массив
        position ++;
    }
}
FillArray(array); 
PrintArray(array);

int i = 0;
int min1 = array[0];
int min2 = array[0];
int ii = 0;
for (i = 0; i < array.Length; i++)
{
    if (array[i] < min1) 
    {
        min1 = array[i];
        ii = i;  
    }
    
}
int j = 0;
int k =0;
for ( j = 0; j < array.Length; j++)
{
    if (array[j] < min2 &&  j!= ii) {min2 = array[j]; 
        k = j;}
          
   
}
Console.WriteLine();
Console.WriteLine(min1);
Console.WriteLine(ii);
Console.WriteLine(min2);
Console.WriteLine(k); */

/* // По заданному номеру четверти показать показать диапазон возможных координат

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
Console.WriteLine(otvet); */

/* // Выводит все элементы массива пока не встретится элемент -1

int q = int.Parse(Console.ReadLine());
int [] a = new int[q];
void FillArray( int length, int [] col)
{
    int index = 0;
    while (index < length)
    {
        col[index] = new Random ().Next(-3, 4); 
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

int fill (int [] coll3)
{
    int x = 0;
            
    while (x < coll3.Length)
    {
        
        if (coll3[x] == -1) break;
        x++;
           
    }
    return x;
} 

void PrintArray2 ( int [] coll, int len)
{
    int pos = 0;
    while (pos < len)
    {
        Console.Write(coll[pos]+ " "); 
        pos ++;
    }
}

FillArray(q,a);
PrintArray(a);
Console.WriteLine();
//filtrarray (a);
int index2 = fill(a);
PrintArray2(a, index2); */

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




