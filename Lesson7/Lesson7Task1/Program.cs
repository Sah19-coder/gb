// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

//В task manager записывать в user scope последний убитый процесс.(перевести на .NET 4.7.2)

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Введите строку данных для записи в файл:");
            // string MyData = Console.ReadLine();
            //[0,1,2]
            List<string> list = new List<string>();
            GC.Collect();
            GC.Collect();
            GC.Collect(); //закинули во 2 поколение!
            
           
            Console.WriteLine("Ваши данные сохранены в файле: MyData.txt.");


        }
    }
}