int x = new Random().Next(100, 1000);
Console.WriteLine("Было сгенерировано число " +x);
int x1 = x/100;
int x2 = x%100;
int x3 = x2%10;
Console.Write(+x1);
Console.Write(+x3);


// Убираем цифру через строку