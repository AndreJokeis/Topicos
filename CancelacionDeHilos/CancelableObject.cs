﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class CancelableObject
{
    public string id;
    public CancelableObject(string id)
    {
        this.id = id;
    }
    public void Cancel()
    {
        Console.WriteLine($"Object {id} Cancel callback");
        // Perform object cancellation here.
    }
}
public class Example1
{
    public static void Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;
        // User defined Class with its own method for cancellation
        var obj1 = new CancelableObject("1");
        var obj2 = new CancelableObject("2");
        var obj3 = new CancelableObject("3");
        // Register the object's cancel method with the token's
        // cancellation request.
        token.Register(() => obj1.Cancel());
        token.Register(() => obj2.Cancel());
        token.Register(() => obj3.Cancel());
        // Request cancellation on the token.
        cts.Cancel();
        // Call Dispose when we're done with the CancellationTokenSource.
        cts.Dispose();
    }
    static void NestedLoops(Rectangle rect, CancellationToken token)
    {
        for (int col = 0; col < rect.columns && !token.IsCancellationRequested; col++)
        {
            // Assume that we know that the inner loop is very fast.
            // Therefore, polling once per column in the outer loop condition
            // is sufficient.
            for (int row = 0; row < rect.rows; row++)
            {
                // Simulating work.
                Thread.SpinWait(5_000);
                Console.Write("{0},{1} ", col, row);
            }
        }
        if (token.IsCancellationRequested)
        {
            // Cleanup or undo here if necessary...
            Console.WriteLine("\r\nOperation canceled");
            Console.WriteLine("Press any key to exit.");
            // If using Task:
            // token.ThrowIfCancellationRequested();
        }
    }
}