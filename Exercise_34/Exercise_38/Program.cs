// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива");
int max;
int min;
int dif;
int a=Convert.ToInt32(Console.ReadLine());
double[] array= new double [a];
for(int i =0; i<array.Length; i++){
    array[i]=new Random().Next(-100,101);
}
Console.WriteLine("["+string.Join(",",array)+"]");
