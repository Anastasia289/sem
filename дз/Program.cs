/* // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Filllist (List <List <double >> mylist)
{
    Console.WriteLine("Задайте размер массива");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    for(int i = 0; i<n;i++)
    {
         mylist.Add(new List <double>());

    for(int j = 0; j<m;j++)
    mylist[i].Add(Math.Round(new Random().NextDouble()*9, 2));
    }
}

void Printlist (List <List <double >> mylist)
{
    for(int i = 0; i<mylist.Count;i++)
    {
       for(int j = 0; j<mylist[i].Count;j++)
    Console.Write(mylist[i][j] + " "); 
    Console.WriteLine();
    }
  
    Console.WriteLine();
}

List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers); */

/* // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

void Filllist (List <List <double >> mylist)
{
    Console.WriteLine("Задайте размер массива");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    for(int i = 0; i<n;i++)
    {
         mylist.Add(new List <double>());

    for(int j = 0; j<m;j++)
    mylist[i].Add(Math.Round(new Random().NextDouble()*9, 2));
    }
}

void Printlist (List <List <double >> mylist)
{
    for(int i = 0; i<mylist.Count;i++)
    {
       for(int j = 0; j<mylist[i].Count;j++)
    Console.Write(mylist[i][j] + " "); 
    Console.WriteLine();
    }
  
    Console.WriteLine();
}

void Checkpos (List <List <double >> mylist)
{
    Console.WriteLine("Какую позицию хотите проверить?");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    double c = 0;
    for(int i = 0; i<mylist.Count;i++)
    {
        if (n<0 || n>mylist.Count || m<0 || m>mylist[i].Count)
        {
            Console.WriteLine("Такой позиции нет");
            break;
        }
       for(int j = 0; j<mylist[i].Count;j++)
    {
        c = mylist[n][m];
    }
    
    } 
    if (c!=0) Console.WriteLine(c);
    Console.WriteLine();
}

List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers);
Checkpos (numbers); */

/* // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] NewArr (int a, int b)
{
int [,] ar = new int [a, b];
for (int i = 0; i<a; i++)
{
    for (int j=0; j<b; j++)
    {
        ar[i,j]= new Random() .Next(0,9);
    }
} 
return ar;
}

void Printarr (int [,] a)
{
    for (int i = 0; i< a.GetLength(0); i++)
{
    for (int j = 0; j< a.GetLength(1); j++)
    {
        Console.Write($"{a[i,j]}" + " ");
    }
        Console.WriteLine();
}
}

double [] medcol (int[,]a)

{
    double [] m = new double [a.GetLength(1)];
    
    for (int i = 0; i< a.GetLength(0); i++)
{
    
    for (int j = 0; j< a.GetLength(1); j++)
    
     m[j] =  m[j] + a[i,j];
    
}
  for (int i = 0; i< a.GetLength(1); i++)
{
m[i] =  m[i]/a.GetLength(0);
}
return m;
}

void Printarr2 (double [] a)
{
    for (int i = 0; i< a.Length; i++)
    {
        Console.Write($" \n Среднее арифметическое столбца {i+1}: {a[i]}");
    }

       Console.WriteLine(); 
    
}

Console.WriteLine("Задайте размер массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int [,] MyArr=  NewArr (n,m);
NewArr (n,m);
Printarr (MyArr);
double [] FindMed = medcol (MyArr);
Printarr2 (FindMed);
 */

/* // Отсортировать в матрице столбцы по убыванию значений
// элементов в первой строке. Использовать заполнение
// случайными значениями.

void Filllist (List <List <double >> mylist)
{
    Console.WriteLine("Задайте размер массива");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    for(int i = 0; i<n;i++)
    {
         mylist.Add(new List <double>());

    for(int j = 0; j<m;j++)
    mylist[i].Add(Math.Round(new Random().NextDouble()*9));
    }
}

void Printlist (List <List <double >> mylist)
{
    for(int i = 0; i<mylist.Count;i++)
    {
       for(int j = 0; j<mylist[i].Count;j++)
    Console.Write(mylist[i][j] + " "); 
    Console.WriteLine();
    }
  
    Console.WriteLine();
}


void Sortlist (List <List <double >> mylist) 
{
    for (int i = 0; i < mylist.Count; i++) 
    {
        for (int j = 0; j < mylist[i].Count; j++) 
        {
           int minind = j; 
           for (int ii = j; ii < mylist[i].Count; ii++) 
        {
            if (mylist[0][ii] < mylist[0][minind])
            {
                minind = ii; 
            }
        }     
            
         double temp = mylist[i][j]; 
         mylist[i][j] = mylist[i][minind]; // где-то здесь полюбому косяк. 
         mylist[i][minind] = temp; 
        }
        
    }
}

List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers);
Sortlist (numbers);
Printlist(numbers); */

// Дана матрица целых чисел размером n*m. Выведите количество седловых точек. 
// (Седловой точкой называется элемент, который является наименьшим в своей строке и наибольшим в своем столбце или, 
// наоборот, наибольшим в своей строке и наименьшим в своем столбце).

void Filllist (List <List <double >> mylist)
{
    Console.WriteLine("Задайте размер массива");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    for(int i = 0; i<n;i++)
    {
         mylist.Add(new List <double>());

    for(int j = 0; j<m;j++)
    mylist[i].Add(Math.Round(new Random().NextDouble()*9));
    }
}

void Printlist (List <List <double >> mylist)
{
    for(int i = 0; i<mylist.Count;i++)
    {
       for(int j = 0; j<mylist[i].Count;j++)
    Console.Write(mylist[i][j] + " "); 
    Console.WriteLine();
    }
  
    Console.WriteLine();
}

void Printlist2 (List <double > M)
{
    Console.WriteLine(); 
    for(int i = 0; i<M.Count;i++) Console.Write(M[i] + " "); 
}
  
    
// void Sedl (List <List <double >> mylist)
// {
    
//     int SedlPoint = 0;
//     List <double > MinRow = new List <double >();
//     List <double > MaxCol = new List <double >();
    
//        for(int i = 0; i<mylist.Count;i++)
//     {
//         double MinI0 = mylist[i][0];
//         for(int j = 0; j<mylist.Count-1;j++)
//        {
//         double MinI1 = Math.Min(mylist[i][j], mylist[i][j+1]);
//         if (MinI1<MinI0) MinI0 = MinI1; 
//        }

//       MinRow.Add(MinI0);
//               Console.Write(MinI0 + "- ");
       
//     }
//      Console.WriteLine();
//     for(int j = 0; j<mylist.Count;j++)
//     {
//         double MaxJ0 = mylist[0][j];
//         for(int i = 0; i<mylist.Count-1;i++)
//        {
//         double MaxJ1 = Math.Max(mylist[i][j], mylist[i+1][j]);
//         if (MaxJ1>MaxJ0) MaxJ0 = MaxJ1; 
      
//        }
//       MinRow.Add(MaxJ0);
      
//         Console.Write(MaxJ0 + "+ ");
        
//     }
// Console.WriteLine();
   
    

//    // Console.WriteLine($"Количество седловых точек равно {SedlPoint}");
//     Console.WriteLine();
    
// }

List <double> MinRow (List <List <double >> mylist)
{
    
    List <double > MinRow = new List <double >();
       
       for(int i = 0; i<mylist.Count;i++)
       {
        double MinI0 = mylist[i][0];
        for(int j = 0; j<mylist.Count-1;j++)
        {
            double MinI1 = Math.Min(mylist[i][j], mylist[i][j+1]);
            if (MinI1<MinI0) MinI0 = MinI1; 
        }
        
        MinRow.Add(MinI0);
       
        }   
    return MinRow;
}

List <double> MaxCol (List <List <double >> mylist)
{
    
    List <double > MaxCol = new List <double >();
       for(int j = 0; j<mylist.Count;j++)
    {
        double MaxJ0 = mylist[0][j];
        for(int i = 0; i<mylist.Count-1;i++)
       {
        double MaxJ1 = Math.Max(mylist[i][j], mylist[i+1][j]);
        if (MaxJ1>MaxJ0) MaxJ0 = MaxJ1; 
      
       }
      MaxCol.Add(MaxJ0);        
    } 
    return MaxCol;
}

List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers);
List <double > MinRowNum = MinRow(numbers);
List <double > MaxColNum = MaxCol(numbers);
Printlist2 (MinRowNum);
//Printlist2 (MaxColNum);

