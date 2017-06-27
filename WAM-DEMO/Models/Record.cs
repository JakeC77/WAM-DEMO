using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAM_DEMO.Models
{
    public class Record
    {
        public string Position { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static List<Record> GetDummyData()
        {
            var records = new List<Record>();
            records.Add(new Record
            {
                FirstName = "Amy",
                LastName = "Smith",
                Position = "CEO"
            });
            records.Add(new Record
            {
                FirstName = "John",
                LastName = "Doe",
                Position = "Vice President"
            });
            records.Add(new Record
            {
                FirstName = "Laura",
                LastName = "Jones",
                Position = "HR Manager"
            });
            records.Add(new Record
            {
                FirstName = "Bob",
                LastName = "Jones",
                Position = "Developer"
            });
            records.Add(new Record
            {
                FirstName = "Tim",
                LastName = "Jones",
                Position = "Developer"
            });
            return records;

        }

    }
}