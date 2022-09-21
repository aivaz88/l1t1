Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2){
    Console.Write("max=");
    Console.WriteLine(num1);
    Console.Write("min=");
    Console.WriteLine(num2);
}
else {
    Console.Write("max=");
    Console.WriteLine(num2);
    Console.Write("min=");
    Console.WriteLine(num1);
}
