using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rndTestConsole
{
    public class CrewMember
    {
        public string EmployeeNumber { get; set; }
        public string Initials { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? EnlistmentDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string LicenseNumber { get; set; }
        public string LoginName { get; set; }
        public bool HasApplicationAccess { get; set; }
    }
}
