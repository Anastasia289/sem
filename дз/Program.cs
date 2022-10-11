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
int number = int.Parse(Console.ReadLine());  // это и правда уже было
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
int number = Math.Abs(c[i]);
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
        Console.WriteLine("номер не прошел"); 
        //break;  // здесь что-то не так. Что? :(((((((((((((
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

void Peremen (int [] AA) // но здесь не совсем по порядку, т.к. позиции менялись местами, а не выталкивались
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

//Известно, что на доске 8×8 можно расставить 8 ферзей так, чтобы они не били друг друга. 
//Вам дана расстановка 8 ферзей на доске, определите, есть ли среди них пара бьющих друг друга.
//Программа получает на вход восемь пар чисел, каждое число от 1 до 8 — координаты 8 ферзей. 
//Если ферзи не бьют друг друга, выведите слово NO, иначе выведите YES.