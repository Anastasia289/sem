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


// Задан список фамилий брокеров товарной биржи из N человек. Обменяйте местами фамилии брокеров: первого и последнего, второго и предпоследнего, третьего от начала и третьего от конца и т.д.
// Например, Олег Вася Камила Дора -> Дора Камила Вася Олег

// void Change (string [] names)
// {
// int A = names.Length;
// int B = A/2;
// string C = string.Empty;

// for (int i = 0; i< B; i++)
// {
//     C = names[i];
//     names[i] = names[A-1-i];
//     names[A-1-i]=C;
// }
// }

// void Printarr ( string [] array)
// {
//     int A = array.Length;
//     int index = 0;
//     while (index < A)
//     {
//         Console.Write(array[index] + " ");
//         index ++;
//     }
//     Console.WriteLine();
// }

// string [] newstr ( )
// {
// Console.WriteLine("Введите количество элементов списка: ");
// int length1 = int.Parse(Console.ReadLine());
// string [] myArr = new string [length1];
// Console.WriteLine("Введите через enter имена: ");
// for (int i=0;i< length1;i++)
// {
//     myArr[i] = Console.ReadLine();
// }
// //System.Console.WriteLine(String.Join(",",myArr));
// return myArr;
// }

// string [] names  = newstr();
// // string [] names = {"Маша", "Петя", "Коля", "Вася", "Андрей", "Оля"};

// Printarr(names);
// Change(names);
// Printarr(names);

// Дан одномерный массив целых чисел. Найдите, сколько раз в нем повторяется самое частое число.
// Например,  15      23      14      23      17      23      21      14 -> 3


// void FillArray ( )
// {
//     int length1 = int.Parse(Console.ReadLine());
//     int [] array = new int [length1];
//     int index = 0;
//     while (index < length1)
//     {
//         array [index] = new Random ().Next(-20, 20); 
//         Console.Write(array[index] + " ");
//         index ++;
//     }
// }

// Myarr [] = FillArray ( );

// int max = Myarr[0];
// int maxind = 0;
// int temp = 0;
// for (int i = 0; i< Myarr.Length, i++)
// {
// for (int j = 0; j< Myarr.Length, j++)
//  {

// }
// if (Myarr[j] == Myarr[i]) temp++;
// if (temp > maxind) maxind = temp;
// }


// Программа должна создать массив из 12 случайных целых чисел из отрезка [-10;10] таким образом, 
//чтобы отрицательных и положительных элементов там было поровну и не было нулей. 
// При этом порядок следования элементов должен быть случаен (т. е. не подходит вариант, когда в массиве 
// постоянно выпадает сначала 6 положительных, а потом 6 отрицательных чисел или же когда элементы постоянно 
//чередуются через один и пр.). Вывести полученный массив на экран.


int []arr = new int [12];
int pos = 0;
int min = 0;

while (pos != 6 && min !=6)
{
    pos = 0;
    min = 0;
    for (int i = 0; i < 12; i++)
    {
    int a = new Random ().Next(-10, 10);
    if (a>0) {pos ++; arr[i] = a;Console.Write(arr[i] + " ");}
    if (a<0) {min ++; arr[i] = a;Console.Write(arr[i] + " ");}
    }
    
}



 Console.WriteLine();
 Console.WriteLine(min);
 Console.WriteLine(pos);
 

/* // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Сделать в функции, сделать проверку на отрицательность.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void stepen ()
{
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());
double C = 0;
if (B>0) C = Math.Pow (A, B);
Console.WriteLine(C);   
}

stepen (); */

/* // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void summ ()
{
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());  // такое уже было
int sum = 0;
int temp = 0;
while ( number != 0)
{
    temp = number%10;
    sum = sum + temp;
   number = number/10;
}
Console.WriteLine(sum); 
}
 
 summ (); */

/* // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Элементы задаются рандомно. Итоговый массив должен содержать в себе суммы цифр числа. 
//Т.е. необходимо подсчитывать суммы цифр чисел и записывать их в новый массив.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 63, 12, 33, 36 -> [9, 3, 6, 9]

void FillArray( int [] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random ().Next(-100, 100); 
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

int [] newline (int [] c)
{
int [] newarray = new int [c.Length];
for (int i=0; i<c.Length; i++)
{
int number = Math.Abs(c[i]); // модуль
int sum = 0;
while ( number != 0)
{
   int temp = number%10;
   sum = sum + temp;
   number = number/10;
   
}
newarray[i]=sum;
}
return newarray;
}

int [] a = new int[8];
FillArray(a);
PrintArray(a);
Console.WriteLine();
int [] goal = newline(a);
PrintArray(goal); */

/* // Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.

int [] FillArray()
{
    Console.WriteLine("введите длину массива");
    int L = int.Parse(Console.ReadLine());
    if (L<0)  
    {
        Console.WriteLine("неееет, так нельзяаааа"); 
        //break; // ну и как это остановить?  :(((((((((((((
    }  
    int [] qwerty = new int [L];
    int index = 0;
    while (index < qwerty.Length)
    {
        qwerty[index] = new Random ().Next(-1, 3); 
        index ++;
    }
    return qwerty;
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
    Console.WriteLine();
}

void Peremen (int [] AA) // вроде как в задаче, но здесь не совсем по порядку, т.к. позиции менялись местами, а не выталкивались
{
    int [] peres = new int [AA.Length];
    int temp = 0;
    int ii = 0;
    int i = 0;

    while (i < AA.Length)
    {
        if (AA[i] == 0) 
        {
            temp = AA[i];
            AA[i] = AA[ii];
            AA[ii]=temp; 
           ii ++;
        }
     
       i ++;
       
    }
}

int [] Peremen2 (int [] AAA) // так мне больше нравится
   
   {
    int [] peres2 = new int [AAA.Length];
    // int temp = 0;
    // int ii = 0;
    int i = 0;

    for (int j = 0; j < AAA.Length; j++)
    {
        if (AAA[j] == 0) 
        {
            peres2[i] = 0;
            i++; 
        }
           
    }
     for (int l = 0; l < AAA.Length; l++)
    {
        if (AAA[l] != 0) 
        {
            peres2[i] = AAA[l];
            i++;    
        }
           
    }
    
    return peres2;   
    }
    
int [] arr1 = FillArray();
PrintArray(arr1); 
int [] arr2 = Peremen2(arr1);
PrintArray(arr2); 
Peremen (arr1);
PrintArray(arr1); */

/* //Известно, что на доске 8×8 можно расставить 8 ферзей так, чтобы они не били друг друга. 
//Вам дана расстановка 8 ферзей на доске, определите, есть ли среди них пара бьющих друг друга.
//Программа получает на вход восемь пар чисел, каждое число от 1 до 8 — координаты 8 ферзей. 
//Если ферзи не бьют друг друга, выведите слово NO, иначе выведите YES.

// К черту ферзей, играю ладьей! И без диагоналей чушь какая-то) 


int [,] PrintNewBoard (int [,] m)
{
    for (int i = 0; i< 8; i++)
{
    for (int j = 0; j< 8; j++)
    {
        Console.Write($"{m[i,j]}" + " ");
    }
        Console.WriteLine();
}
return m;
}

void queen ( int [,] matrix2)
{
   int QueenCount = 1;
   Console.WriteLine("Сколько ферзей хотите поставить?");
   int t = int.Parse(Console.ReadLine());
   while (QueenCount < t+1)
   {
    Console.WriteLine($"Куда поставить ферзя {QueenCount}? ");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    
    if (x<0 || x>7 || y<0 || y>7 ) 
    {Console.WriteLine("Такой клетки нет");
     x = int.Parse(Console.ReadLine());
     y = int.Parse(Console.ReadLine());
    } 
    
    if (matrix2 [x, y] == 2) 
    {
      Console.WriteLine( "Эта уже зянята");
      x = int.Parse(Console.ReadLine());
      y = int.Parse(Console.ReadLine());
    }
    
    if (matrix2 [x, y] == 0) matrix2 [x, y] =2;
    QueenCount ++;
   }
}

void fight ( int [,] matrix3)
{
    int c =0;
   for (int i0 = 0; i0< 8; i0++) 
   {
    for (int j0 = 0; j0< 8; j0++)
    {
        if (matrix3 [i0, j0] == 2)
        
        {
            for (int i1 = 0; i1< 8; i1++)
            {

                for (int j1 = 0; j1< 8; j1++)
                {
                   // if (matrix3 [i0, j1] != 2)  matrix3 [i0, j1] =1 ;  // строка
                   // if (matrix3 [i1, j0] != 2)  matrix3 [i1, j0] =1 ;  // столбец
                   if (matrix3 [i0, j1] == 2 && j1!=j0 ) c++;  // строка
                   if (matrix3 [i1, j0] == 2 && i1!=i0 ) c++;  // столбец
                                         
                  int i2 = i0-j0;
                  int j2 = j0-i0;
                  if (i2<0) i2 = 0;
                  if (j2<0) j2=0;
                  
                             
                }
           

            }
            
        } 

        
            
    }
   }
   if (c>0) Console.WriteLine("упс");
   if (c==0) Console.WriteLine("все ок");
}


int [,] matrix = new int [8,8];
queen (matrix);
fight (matrix);
PrintNewBoard(matrix);  */

/* // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

List<int> qwert ()
{

    List<int> mass = new List<int> ();
    Console.WriteLine("Введите длину массива");
    int k = int.Parse(Console.ReadLine());
    int count = 0;
    while (k>0)
    {
        int i = new Random().Next(100, 999);
        if (i %2 == 0) count++;
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    Console.WriteLine($"\n Количество четных чисел: {count}");
    return mass;
}

List<int>qwerty = qwert(); */

/* // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
List<int> qwert ()
{
    List<int> mass = new List<int> ();
    Console.WriteLine("Введите длину массива");
    int k = int.Parse(Console.ReadLine());
    while (k>0)
    {
        int i = new Random().Next(-10, 10);
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    return mass;
}

int S (List<int> m)
{
    int k = m.Count;
    int i = 1;
    int sum = 0;
    while (i <k) 
    {
        sum = sum +m[i];
        i = i+2;
    }
    return sum;
}

List<int>qwerty = qwert();
Console.WriteLine();
int y = S(qwerty);
Console.WriteLine($"Сумма нечетных элементов равна {y}"); */

 /* // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

List<double> qwert ()
{
    List<double> mass = new List<double> ();
    Console.WriteLine("Введите длину массива");
    int k = int.Parse(Console.ReadLine());
    while (k>0)
    {
        double i = Math.Round (new Random().NextDouble()*100, 2);
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    return mass;
}
void MinMax (List<double>m)
{
    double Max = m[0];
    double Min = m[0];
    double Max1 = m[0];
    double Min1 = m[0];

    for (int i=0; i< m.Count-1; i++)
    {
        Max = Math.Max(m[i], m[i+1]); 
        Min = Math.Min(m[i], m[i+1]);
        if (Max > Max1) Max1 = Max;
        if (Min < Min1) Min1 = Min;
    }
// Console.WriteLine ( "\n максимум " + Max1);
// Console.WriteLine ( "\n минимум " + Min1);
Console.WriteLine ($" \n Разница между минимальным и максимальным числом массива равна {Math.Round(Max1-Min1, 2)}");
}

List<double>qwerty = qwert();
MinMax (qwerty); */


// Дополнительно
// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
//Обновите список только при первом вхождении числа 20.
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

/* List<int> qwert ()
{
    List<int> mass = new List<int> ();
    int k = new Random().Next(7, 25); 
    while (k>0)
    {
        int i = new Random().Next(17, 23);
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    return mass;
}

List<int> change (List<int> q)
{
    //int index = q.Find(x => x == 20);
    int index = q.FindIndex( startIndex: 0, match: x => x == 20);
    if (index < 0) Console.WriteLine("Такого элемента нет");
    if (index >= 0) 
    
    {
        q[index] = 200;
        Console.WriteLine();
        foreach (var n in q) Console.Write(n + " ");
    }
    
    return q;
}

List<int>qwerty = qwert();
change (qwerty); */

/* // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

List<int> qwert ()
{

    List<int> mass = new List<int> ();
    Console.WriteLine("Введите длину массива");
    int k = int.Parse(Console.ReadLine());
    int count = 0;
    while (k>0)
    {
        int i = new Random().Next(100, 999);
        if (i %2 == 0) count++;
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    Console.WriteLine($"\n Количество четных чисел: {count}");
    return mass;
}

List<int>qwerty = qwert(); */

/* // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
List<int> qwert ()
{
    List<int> mass = new List<int> ();
    Console.WriteLine("Введите длину массива");
    int k = int.Parse(Console.ReadLine());
    while (k>0)
    {
        int i = new Random().Next(-10, 10);
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    return mass;
}

int S (List<int> m)
{
    int k = m.Count;
    int i = 1;
    int sum = 0;
    while (i <k) 
    {
        sum = sum +m[i];
        i = i+2;
    }
    return sum;
}

List<int>qwerty = qwert();
Console.WriteLine();
int y = S(qwerty);
Console.WriteLine($"Сумма нечетных элементов равна {y}"); */

 /* // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

List<double> qwert ()
{
    List<double> mass = new List<double> ();
    Console.WriteLine("Введите длину массива");
    int k = int.Parse(Console.ReadLine());
    while (k>0)
    {
        double i = Math.Round (new Random().NextDouble()*100, 2);
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    return mass;
}
void MinMax (List<double>m)
{
    double Max = m[0];
    double Min = m[0];
    double Max1 = m[0];
    double Min1 = m[0];

    for (int i=0; i< m.Count-1; i++)
    {
        Max = Math.Max(m[i], m[i+1]); 
        Min = Math.Min(m[i], m[i+1]);
        if (Max > Max1) Max1 = Max;
        if (Min < Min1) Min1 = Min;
    }
// Console.WriteLine ( "\n максимум " + Max1);
// Console.WriteLine ( "\n минимум " + Min1);
Console.WriteLine ($" \n Разница между минимальным и максимальным числом массива равна {Math.Round(Max1-Min1, 2)}");
}

List<double>qwerty = qwert();
MinMax (qwerty); */


// Дополнительно
// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
//Обновите список только при первом вхождении числа 20.
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

/* List<int> qwert ()
{
    List<int> mass = new List<int> ();
    int k = new Random().Next(7, 25); 
    while (k>0)
    {
        int i = new Random().Next(17, 23);
        mass.Add(i);
        k--;
    }
    foreach (var n in mass) Console.Write(n + " ");
    return mass;
}

List<int> change (List<int> q)
{
    //int index = q.Find(x => x == 20);
    int index = q.FindIndex( startIndex: 0, match: x => x == 20);
    if (index < 0) Console.WriteLine("Такого элемента нет");
    if (index >= 0) 
    
    {
        q[index] = 200;
        Console.WriteLine();
        foreach (var n in q) Console.Write(n + " ");
    }
    
    return q;
}

List<int>qwerty = qwert();
change (qwerty); */

/* // отсортировать массив по возрастанию

int [] FillArray (int a)
{
    int [] ar = new int [a];
    for (int i = 0; i<a; i++)
{
    ar[i] = new Random ().Next(0,20);
}
return ar;
}

void Printarr (int [] ar)
{
    for (int i = 0; i<ar.Length; i++)  Console.Write (ar[i] + " ");
}

void Peremen (int [] AA) 
{
            for (int i = 0; i < AA.Length; i++) 
            {
                int minind = i; 
                for (int j = i; j < AA.Length; j++) 
                {
                    if (AA[j] < AA[minind])
                    {
                        minind = j; 
                    }
                }
                if (AA[minind] == AA[i]) continue;
                int temp = AA[i]; 
                AA[i] = AA[minind];
                AA[minind] = temp;
            }
}
 
Console.WriteLine("Задайте длину массива");
int a = int.Parse(Console.ReadLine());
int [] arr = FillArray (a);
Printarr (arr);
Console.WriteLine();
Peremen(arr );
Printarr (arr); */