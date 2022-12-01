Console.Write("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine()!);
if ((N > 99 & N < 1000 ) || (N < -99 & N > -1000 )){
Console.WriteLine(N % 10);
}
else{
  Console.Write("Не является трехзначным числом");  
}
