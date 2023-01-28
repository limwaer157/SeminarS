// задать массив из 12 элеметов , заполенных числами от (-9, 9)
// Найти сумму положительных / отрицательных чисел эллементов массива

void SumArray(int[] array )
{
    int length = array.Length;
    for (int index = 0; index < length; index = index + 1)
    {
        array[index] = new Random().Next(-9,9);
    }
}
int[] array = new int[12];
SumArray(array);

Console.WriteLine(string.Join("," , array ));

int sumPlus = 0;
int sumMinus = 0;
int length = array.Length;
for (int index = 0; index < length ; index = index + 1)
{
    if (array[index] > 0 ) sumPlus = sumPlus + array[index];
    else sumMinus = sumMinus + array[index];
}
Console.WriteLine(sumMinus);
Console.WriteLine(sumPlus);