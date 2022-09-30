using Awaiting;

IServiceAccess serviceAccess = new MockServiceAccess();

var task = serviceAccess.GetDataAsync();

try
{
    Console.WriteLine($"Thread: {Environment.CurrentManagedThreadId}");
    Console.WriteLine($"IsCompleted: {task.IsCompleted}");
    Console.WriteLine($"IsCompletedSuccessfully: {task.IsCompletedSuccessfully}");
    Console.WriteLine($"IsCanceled: {task.IsCanceled}");
    Console.WriteLine($"IsFaulted: {task.IsFaulted}");

    var text = await task;

    Console.WriteLine();
    Console.WriteLine($"Thread: {Environment.CurrentManagedThreadId}");
    Console.WriteLine($"IsCompleted: {task.IsCompleted}");
    Console.WriteLine($"IsCompletedSuccessfully: {task.IsCompletedSuccessfully}");
    Console.WriteLine($"IsCanceled: {task.IsCanceled}");
    Console.WriteLine($"IsFaulted: {task.IsFaulted}");
    Console.WriteLine();

    Console.WriteLine(text);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Thread: {Environment.CurrentManagedThreadId}");
    Console.WriteLine($"IsCompleted: {task.IsCompleted}");
    Console.WriteLine($"IsCompletedSuccessfully: {task.IsCompletedSuccessfully}");
    Console.WriteLine($"IsCanceled: {task.IsCanceled}");
    Console.WriteLine($"IsFaulted: {task.IsFaulted}");
}


//Console.WriteLine(text);