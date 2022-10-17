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


