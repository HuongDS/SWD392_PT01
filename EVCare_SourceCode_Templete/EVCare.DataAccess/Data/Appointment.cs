using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVCare.DataAccess.Data
{
    public class Appointment
    {
        public string AppointmentId { get; set; } = Guid.NewGuid().ToString();
        public DateTime ScheduledTime { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Assigned, WaitingForAdmin
        public string? TechnicianId { get; set; }
    }
}
