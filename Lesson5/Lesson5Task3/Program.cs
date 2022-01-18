/* 
Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
(*) Список задач(ToDo-list):
написать приложение для ввода списка задач;
задачу описать классом ToDo с полями Title и IsDone;
на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
если задача выполнена, вывести перед её названием строку «[x]»;
вывести порядковый номер для каждой задачи;
при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
записать актуальный массив задач в файл tasks.json/xml/bin.
Console.WriteLine("Hello, World!");
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку из чисел 0..255 через пробел для записи в файл:");
            
            string MyData = Console.ReadLine();
            string[] MyNumbers = MyData.Split(' ');
            var myBytes  = new byte[MyNumbers.Length];
            for(var i=0; i < MyNumbers.Length; ++i)
            {
                myBytes[i] = byte.Parse(MyNumbers[i]);
            }
            
            File.WriteAllBytes("MyData.bin", myBytes);
            Console.WriteLine("Ваши данные сохранены в файле: MyData.bin.");

            Console.ReadKey();
             


        }
    }
}