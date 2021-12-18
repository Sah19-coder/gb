using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


Console.Write("Whats you name?");
string myname = Console.ReadLine();

DateTime mydate = new DateTime(); // Объявляем переменную с датой и инициализируем
mydate = DateTime.Now; // присваиваем текущую дату.
Console.WriteLine(value: $"Привет, {myname}, сегодня {mydate.ToString("dd/MM/yyyy")}.");

