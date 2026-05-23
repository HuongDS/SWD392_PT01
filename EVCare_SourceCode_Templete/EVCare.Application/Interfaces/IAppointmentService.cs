using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVCare.DataAccess.Data;

namespace EVCare.Business.Interfaces
{
    public interface IAppointmentService
    {
        Task<Appointment> CreateAndAutoAssignAsync(DateTime scheduledTime, string description, string skillRequired);
    }
}
