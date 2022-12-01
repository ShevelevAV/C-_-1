Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N < 0)
{
    N = -N;
}
int i = -N;
while (i < N + 1)
{
    Console.WriteLine(i);
    i++;
}