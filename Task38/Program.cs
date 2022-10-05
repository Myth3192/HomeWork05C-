int [] array = new int [5];
Random rand = new Random();
int elemsumm = 0;
int maxnumber = 0;
int minnumber = 0;
for (int i=0; i <array.Length; i++)
{
    array[i]=rand.Next(-100,100);
    Console.WriteLine(array[i]);
}


for (int i = 0; i < array.Length; i++ )
{    
    if (maxnumber<array[i])
    {
        maxnumber = array[i];
    }

}
Console.WriteLine($"Max number is: {maxnumber}");


for (int i = 0; i < array.Length; i++ )
{    
    if (minnumber>array[i])
    {
        minnumber = array[i];
    }

}
Console.WriteLine($"Min number is: {minnumber}");

Console.WriteLine($"Разница между максимальным элементом массива и минимальный составляет: {maxnumber-minnumber}");