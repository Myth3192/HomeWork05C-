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