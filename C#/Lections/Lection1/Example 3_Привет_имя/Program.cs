﻿Console.WriteLine("Как вас зовут?");  //Вывод на экран фразы в скобках.
String username = Console.ReadLine(); //Запомнить данные введенные в строку
Console.Write("Привет,"); // Снова вывод на экран фразы в скобках.
Console.Write(username); // Вывод данных помещенных в контейнер String

// Отличие этого кода от предыдущего в том, что здесь использована
// команда **Console.Write**  вместо **Console.WriteLine
// Текст здесь выведется ОДНОЙ СТРОКОЙ.
// Это будет выглядеть менее уебищно



//                   **WriteLine** - Авто переход на след строку
//                    **Write** - вывод в той же строке.