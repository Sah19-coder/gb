// Decompiled with JetBrains decompiler
// Type: Lesson3Task2.Program
// Assembly: Lesson6Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9CE7DECE-CEF4-4650-A1DF-BBB77C2187CC
// Assembly location: C:\Users\gsa\source\repos\Lesson6\Lesson6Task1\bin\Release\net6.0\Lesson6Task1.dll

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;


#nullable enable
namespace Lesson3Task2
{
  internal class Program
  {
    public static bool PrintTasks()
    {
      foreach (Process process in Process.GetProcesses())
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 3);
        interpolatedStringHandler.AppendFormatted(process.ProcessName);
        interpolatedStringHandler.AppendLiteral("\t\t\t ");
        interpolatedStringHandler.AppendFormatted<int>(process.Id);
        interpolatedStringHandler.AppendLiteral("\t\t ");
        interpolatedStringHandler.AppendFormatted<long>(process.WorkingSet64);
        Console.WriteLine(interpolatedStringHandler.ToStringAndClear());
      }
      return true;
    }

    private static void Main(string[] args)
    {
      Console.WriteLine("Name\t\t PID\t\t  Память\n");
      Process[] processes = Process.GetProcesses();
      foreach (Process process in processes)
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
        interpolatedStringHandler.AppendFormatted(process.ProcessName);
        interpolatedStringHandler.AppendLiteral("\t\t ");
        interpolatedStringHandler.AppendFormatted<int>(process.Id);
        interpolatedStringHandler.AppendLiteral("\t\t ");
        interpolatedStringHandler.AppendFormatted<long>(process.WorkingSet64);
        Console.WriteLine(interpolatedStringHandler.ToStringAndClear());
      }
      Console.WriteLine("\nНажмите 'esc' для выхода, 'K' для завершения процесса.");
      for (ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(); consoleKeyInfo.Key != ConsoleKey.Escape; consoleKeyInfo = Console.ReadKey())
      {
        if (consoleKeyInfo.Key == ConsoleKey.K)
        {
          Console.WriteLine("Введите имя  или PID процесса для его завершения:");
          string s = Console.ReadLine();
          try
          {
            for (int index = 0; index < processes.Length; ++index)
            {
              int result = 0;
              if (processes[index].ProcessName == s || int.TryParse(s, out result) && processes[index].Id == result)
              {
                processes[index].Kill();
                break;
              }
            }
          }
          catch (Exception ex)
          {
            Console.WriteLine(ex.ToString());
          }
        }
        Console.WriteLine("\nНажмите 'esc' для выхода, 'K' для завершения процесса.");
      }
    }
  }
}
