using System;
using System.Collections.Generic;
using System.Text;

namespace Arthur.SofwareDevelop.Domain.Persons
{
    public class Emploee: Staff
    {
        public Emploee(string name, List<TimeRecord> timeRecords) : base(name, 120000, timeRecords)
        {

        }
    }
}
