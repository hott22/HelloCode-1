//Написать программу, которая из имеющегося массива целых чисел 
//формирует массив из чисел, больших 8. Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. 

int[] array = new int[10];
int length = array.Length;
Console.Write("[");
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(3, 12);
    
    Console.Write($"{array[i]} ");
}
Console.Write("] ");
Console.Write("-> ");
Console.Write("[");
for (int i = 0; i < length; i++)
{
    if (array[i] > 8) Console.Write($"{array[i]} ");
}
Console.Write("]");
