// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
{
  sum += n % 10;
  n /= 10;
}
Console.WriteLine (sum);
