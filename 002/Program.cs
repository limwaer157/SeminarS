// Написать программу  для замены элементов на противоположные

void ArrayGange(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index = index + 1)
    {
        array[index] = new Random().Next(-100 , 100);
    }
}
int[] array = new int[20];
ArrayGange(array);
Console.WriteLine(string.Join("," , array ));

int length = array.Length;
for (int index = 0; index < length; index = index + 1 )
{
     array[index] = array[index] * -1 ;
}
Console.WriteLine(string.Join(",", array));