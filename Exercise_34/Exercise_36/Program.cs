// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.WriteLine("Введите размер массива");
int sum=0;
int a=Convert.ToInt32(Console.ReadLine());
int [] array= new int [a];
for(int i =0; i<array.Length; i++){
    array[i]=new Random().Next(-100,101);
}
Console.WriteLine("["+string.Join(", ",array)+"]");
for(int i =1; i<array.Length; i+=2){
    sum=sum+array[i];
}
Console.WriteLine("Сумма элементов на нечетных позициях = "+sum);
