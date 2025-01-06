using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Main thread started.");

        // Queue multiple tasks to the ThreadPool
        ThreadPool.QueueUserWorkItem(Task, "Task 1");
        ThreadPool.QueueUserWorkItem(Task, "Task 2");
        ThreadPool.QueueUserWorkItem(Task, "Task 3");

        // Simulate some work in the main thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main thread working... {i}");
            Thread.Sleep(500);
        }

        Console.WriteLine("Main thread completed.");
    }

    // Task to be executed by thread pool threads
    static void Task(object state)
    {
        Console.WriteLine($"{state} started on thread {Thread.CurrentThread.ManagedThreadId}.");
        Thread.Sleep(1000); // Simulate work
        Console.WriteLine($"{state} completed on thread {Thread.CurrentThread.ManagedThreadId}.");
    }
}
