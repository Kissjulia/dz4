Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

while (b > 0)
{
   Console.WriteLine($" {Math.Pow(a, b)} ");
}

