void Task34()
{
int [] array = new int [4];
Random rand = new Random();
int EvenAmount = 0;
for (int i=0; i <array.Length; i++)
{
    array[i]=rand.Next(100,999);
    Console.WriteLine(array[i]);
}
for (int i=0; i <array.Length; i++)
{
    if(array[i]%2==0)
    {
        EvenAmount++;
    }
}
Console.WriteLine($"Количество четных чисел :{EvenAmount}");

}


void Task36()
{
int [] array = new int [4];
Random rand = new Random();
int elemsumm = 0;
for (int i=0; i <array.Length; i++)
{
    array[i]=rand.Next(-100,100);
    Console.WriteLine(array[i]);
}
for (int i=0; i <array.Length; i++)
{
    if (i%2==0)
    {
        elemsumm = elemsumm + array[i];
    }
}
Console.WriteLine($"Сумма нечетных элемиентов : {elemsumm}");

}

void Task38()
{
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

}

Task38();