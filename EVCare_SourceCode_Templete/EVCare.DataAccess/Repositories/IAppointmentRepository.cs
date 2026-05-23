using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVCare.DataAccess.Data;

namespace EVCare.DataAccess.Repositories
{
    public interface IAppointmentRepository
    {
        Task SaveAsync(Appointment appointment);
        Task UpdateAsync(Appointment appointment);
    }
}
