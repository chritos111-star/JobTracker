using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracker.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Website { get; set; }
    }
}
