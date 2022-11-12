/* // Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их на квадраты

void Filllist (List <List <double >> mylist)
{
    for(int i = 0; i<5;i++)
    {
         mylist.Add(new List <double>());

    for(int j = 0; j<5;j++)
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

void ChangeInd (List <List <double >> mylist)
{
    for(int i = 0; i<mylist.Count;i++)
    {
       for(int j = 0; j<mylist[i].Count;j++)
       if (i%2==0 && j%2==0) mylist[i][j] = Math.Pow(mylist[i][j], 2);
    }
  
    Console.WriteLine();
}



List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers);
ChangeInd (numbers);
Printlist(numbers); */

/* // Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void Filllist (List <List <double >> mylist)
{
    for(int i = 0; i<5;i++)
    {
         mylist.Add(new List <double>());

    for(int j = 0; j<5;j++)
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

void Diasum (List <List <double >> mylist)
{
    double sum = 0;
    for(int i = 0; i<mylist.Count;i++)
    {
       sum = sum +mylist[i][i];  
    }
  
    Console.WriteLine();
    Console.WriteLine(sum);
}
 
List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers);
Diasum  (numbers);
Printlist(numbers);*/

/* //Дан двумерный массив и два числа: i и j. Поменяйте в массиве столбцы с номерами i и j и выведите результат.
// Программа получает на вход размеры массива n и m, затем элементы массива, затем числа i и j.
// Решение оформите в виде функции swap_columns(a, i, j).

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

void ChangeCol (List <List <double >> mylist)
{
    Console.WriteLine("Какие столбцы хотите поменять?");
    int col1= int.Parse(Console.ReadLine());
    int col2 = int.Parse(Console.ReadLine());
    double temp = 0;
    for(int i = 0; i<mylist.Count;i++)
    {
       for(int j = 0; j<mylist.Count;j++)
       {
        if (j == col1)
        {
            temp = mylist[i][j];  
            mylist[i][j] = mylist[i][col2]; 
            mylist[i][col2] = temp;
        }

       }
       
    }
  
    Console.WriteLine();
    
}


List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers);
ChangeCol (numbers);
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

void Sedl (List <List <double >> mylist)
{
    
    int SedlPoint = 0;
    List <double > MinRow = new List <double >();
    List <double > MaxCol = new List <double >();
    
       for(int i = 0; i<mylist.Count;i++)
    {
        double MinI0 = mylist[i][0];
        for(int j = 0; j<mylist.Count-1;j++)
       {
        double MinI1 = Math.Min(mylist[i][j], mylist[i][j+1]);
        if (MinI1<MinI0) MinI0 = MinI1; 
       }

      MinRow.Add(MinI0);

        Console.Write(MinI0 + "+ ");
       
    }
     Console.WriteLine();
    for(int j = 0; j<mylist.Count;j++)
    {
        double MaxJ0 = mylist[0][j];
        for(int i = 0; i<mylist.Count-1;i++)
       {
        double MaxJ1 = Math.Max(mylist[i][j], mylist[i+1][j]);
        if (MaxJ1>MaxJ0) MaxJ0 = MaxJ1; 
      
       }
      MinRow.Add(MaxJ0);
        Console.Write(MaxJ0 + "+ ");
        
    }
Console.WriteLine();
   
    

   // Console.WriteLine($"Количество седловых точек равно {SedlPoint}");
    Console.WriteLine();
    
}


List <List <double >> numbers = new List <List<double >> ();
Filllist (numbers);
Printlist(numbers);
Sedl (numbers);
Printlist(numbers); 