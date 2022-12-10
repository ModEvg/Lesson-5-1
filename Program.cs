/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Write($"Введите размер массива \n");
int A = int.Parse(Console.ReadLine()!);
int [] massiv = new int[A];
int summa = 0;

for (int i = 0; i<A; i++)
    {
         massiv[i] = new Random().Next(100,1000); // Задаем массив из положительных трехзначных чисел
    }
Print();

for (int i = 0; i<A; i++)
    {
        if (massiv[i]%2 == 0) 
        summa=summa+1;
    }
Console.WriteLine($"\n");
Console.WriteLine($"Количество четных чисел равно {summa} \n");

void Print()
    {
        for (int i = 0; i<A; i++)
            {
                Console.Write($"{massiv[i]} "); 
            }   
    }