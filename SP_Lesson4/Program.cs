using SP_Lesson4.Models;
using System.Diagnostics;

namespace SP_Lesson4;

public class Program
{
    static void Main(string[] args)
    {
        // ///////////////////////////////////////

        // ThreadPool.QueueUserWorkItem(WaitCallBackMethod);
        // Console.ReadKey();
        // Console.WriteLine();
        // 
        // ThreadPool.QueueUserWorkItem(WaitCallBackMethod, "Ilhamla ireli");
        // Console.ReadKey();
        // 
        // void WaitCallBackMethod(object? state)
        // {
        //     Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //     Console.WriteLine($"{Thread.CurrentThread.Name} - {state}");
        //     Console.WriteLine(Thread.CurrentThread.IsBackground);
        // }

        // ///////////////////////////////////////

        // ///////////////////////////////////////

        // var student = new Student()
        // {
        //     Id = 1,
        //     Name = "Xayyam",
        //     Surname = "Qasimov"
        // };
        // 
        // ThreadPool.QueueUserWorkItem(PrintStudent, student, true);
        // 
        // Console.ReadKey();
        // 
        // void PrintStudentAsObject(object? state)
        // {
        //     var student = state as Student;
        // 
        //     Console.WriteLine($"ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
        //     Console.WriteLine(student.Id);
        //     Console.WriteLine(student.Name);
        //     Console.WriteLine(student.Surname);
        // }
        // 
        // void PrintStudent(Student student)
        // {
        //     Console.WriteLine($"ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
        //     Console.WriteLine(student.Id);
        //     Console.WriteLine(student.Name);
        //     Console.WriteLine(student.Surname);
        // }

        // ///////////////////////////////////////


        // ///////////////////////////////////////

        // Max, Min, Avaible

        // ThreadPool.GetMinThreads(out int workerthread, out int completionPortThread);
        // Console.WriteLine(workerthread);
        // Console.WriteLine(completionPortThread);

        // ThreadPool.GetMaxThreads(out int workerthread, out int completionPortThread);
        // Console.WriteLine(workerthread);
        // Console.WriteLine(completionPortThread);

        // ThreadPool.GetAvailableThreads(out int workerthread, out int completionPortThread);
        // Console.WriteLine(workerthread);
        // Console.WriteLine(completionPortThread);

        // ///////////////////////////////////////


        // ///////////////////////////////////////

        // {
        //     int operations = 1000;
        //     var watch = new Stopwatch();
        // 
        //     watch.Start();
        //     UseThread(operations);
        //     watch.Stop();
        // 
        //     Console.WriteLine("Thread Milliseconds :" + watch.ElapsedMilliseconds);
        // 
        //     watch.Reset();
        // 
        //     watch.Start();
        //     UseThreadPool(operations);
        //     watch.Stop();
        // 
        // 
        //     Console.WriteLine("ThreadPool Milliseconds :" + watch.ElapsedMilliseconds);
        // 
        // 
        //     void UseThread(int operation)
        //     {
        //         using var countdown = new CountdownEvent(operation);
        //         Console.WriteLine("Threads !!!");
        // 
        //         for (int i = 0; i < operation; i++)
        //         {
        //             var thread = new Thread(() =>
        //             {
        //                 Console.Write($"{Thread.CurrentThread.ManagedThreadId} ");
        // 
        //                 Thread.Sleep(100);
        //                 countdown.Signal();
        //             });
        // 
        //             thread.Start();
        //         }
        // 
        //         countdown.Wait();
        //         Console.WriteLine();
        //     }
        // 
        // 
        //     void UseThreadPool(int operation)
        //     {
        //         using var countdown = new CountdownEvent(operation);
        // 
        //         Console.WriteLine("ThreadPools !!!");
        // 
        //         for (int i = 0; i < operation; i++)
        //         {
        //             ThreadPool.QueueUserWorkItem(_ =>
        //             {
        //                 Console.Write($"{Thread.CurrentThread.ManagedThreadId} ");
        // 
        //                 Thread.Sleep(100);
        //                 countdown.Signal();
        //             });
        //         }
        // 
        //         countdown.Wait();
        //         Console.WriteLine();
        //     }
        // }

        // ///////////////////////////////////////

        // ///////////////////////////////////////

        // Cancelation Token



        // ///////////////////////////////////////

    }
}
