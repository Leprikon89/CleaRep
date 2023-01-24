// Напишите программу которая выводит случайное число из отрезка {10-99}
// и показывает наибольшую цифру числа.

int x = new Random().Next(10, 100);  // Рандомайзер 
Console.WriteLine("Было сгенерировано число "+x);
int x1 = x/10;
int x2 = x%10;
if(x1>x2) Console.WriteLine("Большее число " +x1);
else if(x1<x2) Console.WriteLine("Большее число" +x2);
else Console.WriteLine(" Числа равны");