using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVCare.DataAccess.Data;

namespace EVCare.DataAccess.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public async Task SaveAsync(Appointment appointment)
        {
            // Assume _context.Appointments.Add(appointment);
            // await _context.SaveChangesAsync();
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Appointment appointment)
        {
            // Assume _context.Appointments.Update(appointment);
            // await _context.SaveChangesAsync();
            await Task.CompletedTask;
        }
    }
}
