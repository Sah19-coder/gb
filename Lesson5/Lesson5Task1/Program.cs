using System;
using System.IO;

    // Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
    namespace HomeWork
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите строку данных для записи в файл:");
                string MyData = Console.ReadLine();

                File.WriteAllText("MyData.txt", MyData);
                Console.WriteLine("Ваши данные сохранены в файле: MyData.txt.");


            }
        }
    }