/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

/* void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}
}
Console.WriteLine("Основной массив: ");
int m = 3, n = 4;
int[,] mass = new int[m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(0,10);
    }
}
Print(mass);

Console.WriteLine("Новый массив: ");

int spare = 0;
for (int i = 0; i < mass.GetLength(1); i++)
{
    spare = mass[0,i];
    mass[0,i] = mass[mass.GetLength(0)-1,i];
    mass[mass.GetLength(0)-1,i] = spare; 
}
Print(mass);  */



/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */


/* void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}
}
Console.WriteLine("Основной массив: ");
int m = 3, n = 3;
int[,] mass = new int[m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(0,10);
    }
}
Print(mass);

if (mass.GetLength(0) != mass.GetLength(1))
{
    Console.WriteLine("Строки и столбцы нельзя поменять местаим!");
}
else
{
Console.WriteLine("Новый массив: ");

int help = 0;
for (int i = 0; i < mass.GetLength(1); i++)
{
    for (int j = i + 1; j < mass.GetLength(0); j++)
    {
        help = mass[i,j];
        mass[i,j] = mass[j,i];
        mass[j,i] = help;   
    }
}
Print(mass);
}
 */

/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */


// для одинарного массива

/* int count = 0;
int N = 9;
int[] mass = new int[N];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 9);
}
Console.WriteLine();
for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

for (int a = 0; a < N; a++)
{
    count = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] == a)
        {
            count++;
        }
    }
    if (count > 0)
    {
       Console.WriteLine($"Количество {a}: {count}"); 
    }
    
} */

// для двумерного массива

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 3, n = 3, max = 10;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, max);
    }
}
Print(mass);

int count = 0;

for (int a = 0; a <= max; a++)
{
    count = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] == a)
            {
                count++;
            }
        }
    }
    if (count > 0)
    {
        Console.WriteLine($"Количество {a}: {count}");
    }
} */

// РЕШЕНИЕ №2 (С ЛЕКЦИИ) - не доделано

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

int count = 0; */
/* int num = mass[0,0];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i,j] == num) count++;            //поиск поличесва значений элемента массива [0,0]
    }
} */

//Console.WriteLine($"{num} встречается {count} раз");

/* int[] array = new int[mass.Length];             //создаем новый массив для хранения значений первого массива

int k = 0;
bool finded = false;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        finded = false;
        for (int l = 0; l < k; l++)
        {
            if (array[l] == mass[i, j])
            {
                finded = true;
                break;
            }
        }

        if (!finded)  //! - знак отрицания - не файндед
        {


            array[k] = mass[i, j];            //копируем значения двумерного массива в одномерный
            k++;
        }
    }
}

for (int i = 0; i < k; i++)
{
    Console.Write(array[i] + " ");
}
 */





/* Задача 59: Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

//РЕШЕНИЕ ИЗ ЛЕКЦИИ
/* 
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 4, n = 4, max = 10;
int minElem = 100;
int minStrok = 100;
int minStolb = 100;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, max);
    }
}
Print(mass);

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < minElem)
        {
            minElem = mass[i, j];
            minStrok = i;
            minStolb = j;
        }
    }
}
Console.WriteLine("Минимальный элемент массива: " + minElem);
Console.WriteLine("Строка: " + minStrok);
Console.WriteLine("Столбец: " + minStolb);
Console.WriteLine();

int[,] mass1 = new int[mass.GetLength(0)-1, mass.GetLength(1)-1];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if ((i != minStrok) && (j != minStolb))
        {
            
            int k = i;
            if (i > minStrok) k = i -1;
            int l = j; 
            if (l > minStolb) l = l - 1;
            mass1[k,l] = mass[i,j];
        }
    }
    
}
Print(mass1);

 */


/// МОЕ РЕШЕНИЕ - НЕ СМОГ
/* 
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 4, n = 4, max = 10;
int minElem = 100;
int minStrok = 100;
int minStolb = 100;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, max);
    }
}
Print(mass);

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < minElem)
        {
            minElem = mass[i, j];
            minStrok = i;
            minStolb = j;
        }
    }
}
Console.WriteLine("Минимальный элемент массива: " + minElem);
Console.WriteLine("Строка: " + minStrok);
Console.WriteLine("Столбец: " + minStolb);
Console.WriteLine();

int[,] mass1 = new int[m, n];

if ((minStrok != 0) && (minStolb != 0))
{

    for (int i = 0; i < minStrok; i++)
    {
        for (int j = 0; j < minStolb; j++)
        {
            mass1[i, j] = mass[i, j];
        }
    }
    if (minStrok < mass.GetLength(0))
    {
        for (int i = minStolb + 1; i < mass.GetLength(0); i++)
        {
            for (int j = minStrok + 1; j < mass.GetLength(1); j++)
            {
                mass1[i, j] = mass[i, j];
            }
        }
    }
}
else
{

    for (int i = 1; i < mass.GetLength(0); i++)
    {
        for (int j = 1; j < mass.GetLength(1); j++)
        {
            mass1[i, j] = mass[i, j];
        }
    }



}
Print(mass1);
 */

// ДОМАШНЕЕ ЗАДАНИЕ 06-07-2022 ЛЕКЦИИ №8
/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */
/* 
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 2, n = 4, max = 10;


int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, max);
    }
}
Print(mass);
Console.WriteLine();

int temp;

for (int k = 0; k < mass.GetLength(0); k++)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < mass.GetLength(1) - 1 - i; j++)
        {
            if (mass[k,j] > mass[k,j + 1])
            {
                temp = mass[k,j];
                mass[k,j] = mass[k,j + 1];
                mass[k,j + 1] = temp;
            }
        }
    }
}

Print(mass); */


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 3, n = 3, max = 10;

int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, max);
    }
}
Print(mass);
Console.WriteLine();

int[] arr = new int[3];
for (int i = 0; i < mass.GetLength(0); i++)
{
    int sum = 0;

    for (int j = 0; j < mass.GetLength(1); j++)
    {
        sum = sum + mass[i, j];
    }
    Console.WriteLine($"Сумма элементов строки #{i}: {sum}");
    arr[i] = sum;
}

Console.WriteLine();

if ((arr[0] < arr[1]) & (arr[0] < arr[2]))
{
    Console.WriteLine("Строка с наименьшей суммой элементов: 0");
}
else if  ((arr[1] < arr[0]) & (arr[1] < arr[2]))
{
    Console.WriteLine("Строка с наименьшей суммой элементов: 1");
}
else
{
    Console.WriteLine("Строка с наименьшей суммой элементов: 2");
} 

Console.WriteLine(); */

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 2, n = 3, max = 10;
int[,] mass1 = new int[m, n];
for (int i = 0; i < mass1.GetLength(0); i++)
{
    for (int j = 0; j < mass1.GetLength(1); j++)
    {
        mass1[i, j] = new Random().Next(1, max);
    }
}
int[,] mass2 = new int[n, m];
for (int i = 0; i < mass2.GetLength(0); i++)
{
    for (int j = 0; j < mass2.GetLength(1); j++)
    {
        mass2[i, j] = new Random().Next(1, max);
    }
}
Console.WriteLine("Матрица №1 3х2:");
Print(mass1);
Console.WriteLine("Матрица №2 3х2:");
Print(mass2);
int[,] mass3 = new int[m, m];
int summ = 0;
int num = 0;
int[] arr = new int[3];

//0.0
for (int i = 0; i < 1; i++)
{
    summ = 0;
    for (int j = 0; j < 3; j++)
    {
        summ = mass1[i, j] * mass2[j, i];
        /* Console.Write(summ + " "); */
        arr[j] = summ;
    }
}
mass3[0,0] = arr[0]+arr[1]+arr[2];

//0.1

mass3[0,0] = arr[0]+arr[1]+arr[2];

for (int i = 0; i < 1; i++)
{
    summ = 0;
    for (int j = 0; j < 3; j++)
    {
        summ = mass1[i, j] * mass2[j, i+1];
        /* Console.Write(summ + " "); */
        arr[j] = summ;
    }
}
mass3[0,1] = arr[0]+arr[1]+arr[2];

// 1.1

for (int i = 1; i < 2; i++)
{
    summ = 0;
    for (int j = 0; j < 3; j++)
    {
        summ = mass1[i, j] * mass2[j, i];
        /* Console.Write(summ + " "); */
        arr[j] = summ;
    }
}
mass3[1,1] = arr[0]+arr[1]+arr[2];

//1.0

for (int i = 0; i < 1; i++)
{
    summ = 0;
    for (int j = 0; j < 3; j++)
    {
        summ = mass1[i+1, j] * mass2[j, i];
        /* Console.Write(summ + " "); */
        arr[j] = summ;
    }
}

mass3[1,0] = arr[0]+arr[1]+arr[2];

Console.WriteLine("Результат перемножения матриц:");
Print(mass3);
Console.WriteLine();

/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */


/* int m = 3, n = 3, l = 3;

int[,,] mass = new int[m, n, l];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int g = 0; g < mass.GetLength(2); g++)
        {
            mass[i, j, g] = new Random().Next(10, 100);
            Console.WriteLine($"{mass[i, j, g]} [{i},{j},{g}]");
        }
    }
} */

/* Задача 62: Заполните спирально массив 4 на 4. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Основной массив: ");
int m = 4, n = 4, k = 10, max = 10;

int[,] mass = new int[m, n];

for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = k;
        k++;
    }
}
for (int i = 1; i < 4; i++)
{
    int j = 3;
    mass[i, j] = k;
    k++;
}
for (int i = 3; i < 4; i++)
{
    for (int j = 2; j >= 0; j--)
    {
        mass[i, j] = k;
        k++;
    }
}
for (int i = 2; i > 0; i--)
{
    int j = 0;
    mass[i, j] = k;
    k++;
}
for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < mass.GetLength(1)-1; j++)
    {
        mass[i, j] = k;
        k++;
    }
}
for (int i = 2; i < 3; i++)
{
    for (int j = 2; j > 0; j--)
    {
        mass[i, j] = k;
        k++;
    }
}
Print(mass);
Console.WriteLine(); */