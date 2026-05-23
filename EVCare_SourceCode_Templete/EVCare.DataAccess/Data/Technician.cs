using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVCare.DataAccess.Data
{
    public class Technician
    {
        public string TechnicianId { get; set; }
        public string FullName { get; set; }
        public string SkillCategory { get; set; }
        public string CurrentStatus { get; set; } // Active, Inactive, Busy
    }
}
