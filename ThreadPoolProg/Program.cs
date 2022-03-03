using System;
using System.Threading;

namespace Exercises
{ 
class ThreadPoolProg
{
    public void ThreadFun1(Object obj)
    {
        int loop = 0;
        for (loop = 0; loop <= 4; loop++)
        {
            Console.WriteLine("Thread1 is excecuting");
        }
    }

    public void ThreadFun2(Object obj)
    {
        int loop = 0;
        for (loop = 0; loop <= 4; loop++)
        {
            Console.WriteLine("Thread2 is excecuting");
        }
    }

    public static void Main()
    {
        ThreadPoolProg TP = new ThreadPoolProg();
        for (int i = 0; i < 2; i++)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(TP.ThreadFun1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(TP.ThreadFun2));
        }
        Console.ReadKey();
    }
}
}