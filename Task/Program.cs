﻿// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

Console.Clear();


string[] array = {"hello", "2", "world", ":-)"};
string[] result = new string[array.Length];

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        result[count] = array[i];
        count++;
        }
    }

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{result[i]}\t");
}

