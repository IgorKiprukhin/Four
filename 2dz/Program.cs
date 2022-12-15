Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int lenght = GetLengthOfNumber(n);
int []array = new int [lenght];
int a = n;
for(int i = 0; i < lenght; i++ )
{
    array[i] = n % 10;
    n/=10;
}
int sum = 0;
for(int i = 0; i < lenght; i++)
{
    if(array[i] != 0)
    {
        if(a % array[i] == 0)//array[i]является ли делителем
            {
           sum += array[i];// сумма подходящих цифр
            }
    } 
}
Console.WriteLine(sum);
int GetLengthOfNumber(int val)
{
    int count = 0; 
    while(val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}
