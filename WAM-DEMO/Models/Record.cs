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
                FirstName = "Bob",
                LastName = "Loblaw",
                Position = "Lawyer/Blogger"
            });
            return records;
            
        }

    }
}