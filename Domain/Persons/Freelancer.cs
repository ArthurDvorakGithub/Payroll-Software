using System;
using System.Collections.Generic;
using System.Text;

namespace Arthur.SofwareDevelop.Domain
{
    public class Freelancer: Person
    {
        public Freelancer(string name,List<TimeRecord> timeRecords) : base(name, timeRecords)
        {

        }
    }
}
