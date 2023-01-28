// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void Array123(int[] array)
{
    int length = array.Length;
    
    for (int index = 0; index < length; index = index + 1)
    {
        array[index] = new Random().Next(1, 999);

    }
}
int[ ] array = new int[10];
Array123(array);
    
Console.WriteLine(string.Join( " ", array));
 
int sumNumber = 0;
int length = array.Length;

for (int index = 0; index < length; index = index + 1)
{
    if (  array[index] > 10 ) sumNumber = sumNumber + 1 ;
    if (array[index] > 99 ) sumNumber = sumNumber - 1;
}
Console.WriteLine(sumNumber);