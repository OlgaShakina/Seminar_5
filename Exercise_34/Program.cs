﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Введите размер массива");
int count=0;
int a=Convert.ToInt32(Console.ReadLine());
int[] array= new int [a];
for(int i=0; i<array.Length; i++){
    array[i]=new Random().Next(100,1000);
}
Console.WriteLine("["+string.Join(", ",array)+"]");
for(int i =0; i<array.Length; i++){
    if(array[i]%2==0){
        count++;
    }
}
Console.WriteLine("Количество четных чисел в массиве ="+count);