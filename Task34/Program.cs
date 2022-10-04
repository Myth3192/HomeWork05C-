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