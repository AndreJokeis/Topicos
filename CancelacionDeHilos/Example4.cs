﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Example4
{
    static void Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        StartWebRequest(cts.Token);
        // Cancellation will cause the web
        // request to be cancelled.
        cts.Cancel();
    }
    static void StartWebRequest(CancellationToken token)
    {
        var client = new HttpClient();
        token.Register(() =>
        {
            client.CancelPendingRequests();
            Console.WriteLine("Request cancelled!");
        });
        Console.WriteLine("Starting request.");
        client.GetStringAsync(new Uri("http://www.contoso.com"));
    }
}
