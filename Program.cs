/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Write($"Введите размер массива \n");
int A = int.Parse(Console.ReadLine()!);
int [] massiv = new int[A];
int summa = 0;

for (int i = 0; i<A; i++)
    {
         massiv[i] = new Random().Next(-100,100); // Задаем массив
    }
Print();

for (int i = 1; i<A;)
    {
        summa=summa+massiv[i];
        i=i+2;
    }
Console.WriteLine($"\n");
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, равна {summa} \n");

void Print()
    {
        for (int i = 0; i<A; i++)
            {
                Console.Write($"{massiv[i]} "); 
            }   
    }