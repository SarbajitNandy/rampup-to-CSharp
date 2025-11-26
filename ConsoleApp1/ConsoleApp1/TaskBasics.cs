// using System.Collections;
// using System.Diagnostics;


// async Task<string> basicTask()
// {
//     Task<string> task = Task.Run(() =>
//     {
//         Thread.Sleep(2000);
//         return "Task 1 Completed";
//     });

//     return await task;

// }

// async Task<string> basicTask2()
// {
//     Task<string> task = Task.Run(() =>
//     {
//         Thread.Sleep(2000);
//         return "Task 2 Completed";
//     });

//     return await task;
// }

// var result = await Task.WhenAll(basicTask(), basicTask2());

// Console.WriteLine("Waiting for tasks to complete...");
// Console.WriteLine(result.GetType());

// // accessing individual results
// Console.WriteLine(result[0]);
