Console.Write("Введите число а: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());
int doubleB = numberB*numberB;
if (numberA == doubleB){
Console.WriteLine("квадрат второго числа равен первому числу");
}
else{
Console.WriteLine("квадрат второго числа не равен первому числу"); 
}  
