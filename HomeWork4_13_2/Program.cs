static class Program {

    static void Method1() {
        Thread.CurrentThread.IsBackground = false;
        Console.WriteLine($"Method1: Start ({Thread.CurrentThread.ManagedThreadId} / {Task.CurrentId})");
        Thread.Sleep(1500);
        Console.WriteLine("Method1: End");
    }

    static void Method2() {
        Thread.CurrentThread.IsBackground = false;
        Console.WriteLine($"Method2: Start ({Thread.CurrentThread.ManagedThreadId} / {Task.CurrentId})");
        Thread.Sleep(1500);
        Console.WriteLine("Method2: End");
    }

    static void Main() {
        Parallel.Invoke(new ParallelOptions { MaxDegreeOfParallelism = 2 },
            () => Task.Run(() => Method1()),
            () => Task.Run(() => Method2())
        );

        Console.WriteLine($"Main thread ({Thread.CurrentThread.ManagedThreadId})");
    }

}
