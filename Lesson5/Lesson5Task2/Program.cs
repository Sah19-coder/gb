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
            DateTime MyTime = DateTime.Now;
            Console.WriteLine($"Текущее время:{MyTime.ToString()} будет дописано в файл startup.txt");
            File.AppendAllText("startup.txt", MyTime.ToString() + "\n");
            Console.ReadKey();



        }
    }
}