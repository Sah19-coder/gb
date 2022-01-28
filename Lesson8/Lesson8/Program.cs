using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В task manager записывать в user scope последний убитый процесс.(перевести на .NET 4.7.2)

namespace Lesson3Task2
{
    class Program
    {

        public static bool PrintTasks()
        {
            Process[] tasks = Process.GetProcesses();
            foreach (Process process in tasks)
            {
                Console.WriteLine($"{process.ProcessName}\t\t\t {process.Id}\t\t {process.WorkingSet64}");
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name\t\t PID\t\t  Память\n");
            Process[] tasks = Process.GetProcesses();
            foreach (Process process in tasks)
            {
                Console.WriteLine($"{process.ProcessName}\t\t {process.Id}\t\t {process.WorkingSet64}");
            }
            Console.WriteLine("\nНажмите 'esc' для выхода, 'K' для завершения процесса.");
            ConsoleKeyInfo command = Console.ReadKey();
            while (command.Key != ConsoleKey.Escape)
            {
                switch (command.Key)
                {
                    case ConsoleKey.K:
                        Console.WriteLine("Введите имя  или PID процесса для его завершения:");
                        string Name = Console.ReadLine();
                        try
                        {
                            for (var i = 0; i < tasks.Length; i++)
                            {
                                int result = 0;
                                if (tasks[i].ProcessName == Name ||
                                    (int.TryParse(Name, out result) && tasks[i].Id == result))
                                {

                                    tasks[i].Kill();
                                    //Console.WriteLine($"Процесс {}  завершен.");
                                    break;
                                }

                            }
                        }
                        catch (Exception ex)
                        { Console.WriteLine(ex.ToString()); }
                        break;
                }
                Console.WriteLine("\nНажмите 'esc' для выхода, 'K' для завершения процесса.");
                command = Console.ReadKey();
            }

        }
    }
}