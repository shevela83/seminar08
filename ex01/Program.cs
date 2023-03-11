/*Задача 53:** Задайте двумерный массив. 
    Напишите программу, которая поменяет местами первую и последнюю строку массива.

    Например, задан массив:

    1 4 7 2

    5 9 2 3

    8 4 2 4

    В итоге получается вот такой массив:

    8 4 2 4

    5 9 2 3

    1 4 7 2*/
// не все решение
    int [,] NewArray(int[,]array)
{ 

int temp =0;

    for(int i=0; i<array.GetLength(1);i++)
    {
        temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;

    }
    return array;
    
}