﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Timers;

namespace Cansat2021
{
    //public class TimerClass
    //{
    //    private static System.Timers.Timer aTimer;

    //    public static void Main()
    //    {
    //        SetTimer();

    //        System.Diagnostics.Debug.WriteLine("\nPress the Enter key to exit the application...\n");
    //        System.Diagnostics.Debug.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
    //        Console.ReadLine();
    //        aTimer.Stop();
    //        aTimer.Dispose();

    //        System.Diagnostics.Debug.WriteLine("Terminating the application...");
    //    }

    //    private static void SetTimer()
    //    {
    //        // Create a timer with a two second interval.
    //        aTimer = new System.Timers.Timer(1000);
    //        // Hook up the Elapsed event for the timer. 
    //        aTimer.Elapsed += OnTimedEvent;
    //        aTimer.AutoReset = true;
    //        aTimer.Enabled = true;
    //    }

    //    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    //    {
    //        System.Diagnostics.Debug.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
    //                          e.SignalTime);
    //    }
    //}
    //// The example displays output like the following:
    ////       Press the Enter key to exit the application...
    ////
    ////       The application started at 09:40:29.068
    ////       The Elapsed event was raised at 09:40:31.084
    ////       The Elapsed event was raised at 09:40:33.100
    ////       The Elapsed event was raised at 09:40:35.100
    ////       The Elapsed event was raised at 09:40:37.116
    ////       The Elapsed event was raised at 09:40:39.116
    ////       The Elapsed event was raised at 09:40:41.117
    ////       The Elapsed event was raised at 09:40:43.132
    ////       The Elapsed event was raised at 09:40:45.133
    ////       The Elapsed event was raised at 09:40:47.148
    ////
    ////       Terminating the application...
}