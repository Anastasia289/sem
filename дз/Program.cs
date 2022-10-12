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

 /*// Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.

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

// К черту ферзей, играю ладьей) 


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
