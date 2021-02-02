using Arthur.SofwareDevelop.Domain;
using Arthur.SofwareDevelop.Persistence;
using System;
using System.Collections.Generic;

namespace Arthur.SofwareDevelop.SofwareDevelopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("mike", new List<TimeRecord>
            {
                new TimeRecord(DateTime.Today.AddDays(-3), "MIKE", 8, "test message"),
                new TimeRecord(DateTime.Today.AddDays(-2), "MIKE", 9, "test message"),
                new TimeRecord(DateTime.Today.AddDays(-1), "MIKE", 7, "test message"),
            });
                      

            Console.WriteLine(manager.TotalPay);
            Console.ReadLine();
        }
    }
}
