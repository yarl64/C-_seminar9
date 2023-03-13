Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 7 == 0 && x % 23 == 0)
{
Console.WriteLine($" Число {x} кратно 7 и кратно 23 ");

}
else
{
Console.WriteLine($" Число {x} не кратно 7 и не кратно 23 ");
}