/* // ищем максимальное из девяти чисел

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;  // механизм по поиску максимума  из трех чисел
}
int a1 = 3;
int b1 = 15;
int c1 = 100;
int a2 = 30;
int b2 = 14;
int c2 = 197660;
int a3 = 322;
int b3 = 14;
int c3 = 1330;

// int Max1 = Max (a1, b1, c1);
// int Max2 = Max (a2, b2, c2);
// int Max3 = Max (a3, b3, c3);
// int max = Max (Max1, Max2, Max3); 

int max = Max (Max (a1, b1, c1), Max (a2, b2, c2), Max (a3, b3, c3)); // аналогично предыдущим 4м строчкам, но без лишних переменных

Console.WriteLine(max); */

/* // аналогично, но с массивом


  int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;  // механизм по поиску максимума  из трех чисел
}
int []array = {1,13,134,34,4323,13,443,455,1};
int max = Max (
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]),
    Max (array[6], array[7], array[8])); 

Console.WriteLine(max); */

/* // Найти нужный элемент в массиве

int [] array = {1, 4, 554, 34, 34, 4, 56, 45, 2344};
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерываемся при первом успехе. иначе покажет все совпадения
    }
    index ++;
} */

/* // заполняем случайными числами, выводим массив, ищем индекс нужного числа 
int [] array = new int [10];  //cоздали новый массив
void FillArray( int [] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random ().Next(1, 10); // это метод, чтобы заполнить массив случайными числами
        index ++;
    }
}

void PrintArray( int [] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(coll[position]+ " "); // это метод, чтобы распечатать массив
        position ++;
    }
}

int IndexOf(int [] col, int find)
{
    int count = col.Length;
    int index = 0;
    int position = -1; // -1, а не ноль, чтобы было видно случаи  когда искомое не в массиве
    while(index < count)
    {
        
        if (col[index] == find) 
        {
            position = index;
            // break; // если он здесь есть, увидим первое нужное значение, если нет - последнее
        }
        index++;
    }
    return position;
}
FillArray(array); // так выглядит вызов метода
PrintArray(array);
int pos = IndexOf(array, 4);
Console.WriteLine();
Console.WriteLine(pos); */

// Вводится строка слов, разделенных пробелами. Найти самое длинное слово и вывести его на экран.
 
Console.WriteLine("Введите предложение");
string str = Console.ReadLine();
string [] word = str.Split(' ');
int x = word.Length;
int [] aaa = new int [x]; // числовой массив с длиной равной количеству слов
int i = 0;
string j = " ";
int a = 0;

 for (i = 0; i < x; i++)
{
    j = word[i];
    a = j.Length;
    aaa[i] = a;  // заполняем его количеством букв в каждом слове
}
/*

void PrintArray( int [] aaa)
{
    int count = aaa.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(aaa[position]+ " "); // распечатать массив, чтобы сравнить цифры в массиве с кол-вом букв
        position ++;
    }
}

PrintArray(aaa);*/

int max = aaa[0];
int ii = 0;
 for (ii = 0; ii < x; ii++)
{
    if (aaa[ii] > max) max = aaa[ii];   // ищем максимальное число
  
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
            // break; // если он здесь есть, увидим первое нужное значение, если нет - последнее или единственное
        }
        index++;
    }
    return position;
}
int pos = Index(aaa, max);

// Console.WriteLine(pos);
// Console.WriteLine(max);
Console.WriteLine(word[pos]);
