/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Write($"Введите размер массива \n");
int A = int.Parse(Console.ReadLine()!);
int[]massiv = new int[A];
for (int i = 0; i<A; i++)
    {   
        Console.WriteLine($"{i} элемент массива");
        massiv[i] = int.Parse(Console.ReadLine()!); // Задаем массив
    }
int max = massiv[0];
int min = massiv[0];

Print();
maximum();
minimum();
Console.WriteLine($"Разница между максимальным значением, равным {max}, и минимальным значением, равным {min}, элементами массива равна {max-min}\n");

void Print()
    {
        for (int i = 0; i<A; i++)
            {
                Console.Write($"{massiv[i]} "); 
            }   
    }

void maximum()
    {
        for (int i = 1; i<A; i++)
        {
            if (max<massiv[i])
            max = massiv[i];
        }
    }

void minimum()
    {
        for (int i = 1; i<A; i++)
        {
            if (massiv[i]<min)
            min = massiv[i];
        }
    }