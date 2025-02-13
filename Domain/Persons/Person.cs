﻿using System;
using System.Collections.Generic;

namespace Arthur.SofwareDevelop.Domain
{
    public class Person
    {
        public string Name { get;}

        public List<TimeRecord> TimeRecords { get; set; }

        public Person(string name, List<TimeRecord> timeRecords)
        {
            Name = name;
            TimeRecords = timeRecords;
        }
    }
}
