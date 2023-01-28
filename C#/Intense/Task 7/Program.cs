Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int y = Convert.ToInt32(Console.ReadLine());
int remains = y%x;
if (remains == 0)
{
 Console.WriteLine("Кратно");   
}
else
{
  Console.WriteLine(" Не Кратно");  
}