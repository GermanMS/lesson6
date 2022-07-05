// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Write("введите количество элементов массива");
int M= Convert.ToInt32(Console.ReadLine());
int[] A = new int [M];
Console.Write("введите элементы массива"+ " ");
for( int i=0; i<A.Length; i++)
{
    A [i] = int.Parse(Console.ReadLine());
}
for (int i=0; i<A.Length; i++)
{
Console.Write(A[i] +" ");
}
Console.Write("введенный массив");
int b=0;
for (int i=0; i<A.Length; i++)
{
    if(A[i]>0)
    {
    b= b+1;
    }
}
Console.Write($"\n{b} чисел больше 0");