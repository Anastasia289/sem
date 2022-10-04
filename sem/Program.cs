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

/* Console.WriteLine("Введите число 1");
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

