using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Position { get; set; }

        public string ApplicationStatus { get; set; }

        public DateTime DateApplied { get; set; }
        public string CompanyName { get; set; }
    }
}
