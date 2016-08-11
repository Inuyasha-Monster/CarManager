using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.WebSignalRClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:22222/");
            var hubProxy = hubConnection.CreateHubProxy("MessageHub");
            hubConnection.Start().Wait();

            System.Diagnostics.PerformanceCounter cpu = new System.Diagnostics.PerformanceCounter();
            cpu.CategoryName = "Processor";
            cpu.CounterName = "% Processor Time";
            cpu.InstanceName = "_Total";

            while (true)
            {
                string cpuUage = cpu.NextValue().ToString();
                Console.WriteLine(cpuUage);
                if (hubConnection.State == ConnectionState.Connected)
                {
                    hubProxy.Invoke("SendMessage", cpuUage);
                }

                Task.Delay(TimeSpan.FromSeconds(1)).Wait();
            }
        }
    }
}
