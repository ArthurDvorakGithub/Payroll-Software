﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arthur.SofwareDevelop.Domain
{
    public class Manager : Staff
    {
        public decimal MonthBonus  => 20000;
        public decimal TotalPay { get;}
        public Manager(string name, List<TimeRecord> timeRecords) : base(name, 200000, timeRecords)
        {
            decimal payPerHour = MonthSalary / Settings.WorkHoursInMonth;
            decimal totalPay = 0;
            decimal bonusPerDay = (MonthBonus / Settings.WorkHoursInMonth) * Settings.WorkHourInDay;

            foreach(var timeRecord in timeRecords)
            {
                if(timeRecord.Hours <= Settings.WorkHourInDay)
                {
                    totalPay += timeRecord.Hours * payPerHour;
                }
                else //переработка
                { 
                    totalPay += Settings.WorkHourInDay * payPerHour + bonusPerDay;
                }
            }
            TotalPay = totalPay;
        }
    }
}
