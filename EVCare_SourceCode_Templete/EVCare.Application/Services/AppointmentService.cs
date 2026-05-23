using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVCare.Business.Interfaces;
using EVCare.DataAccess.Data;
using EVCare.DataAccess.Repositories;

namespace EVCare.Business.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepo;
        private readonly ITechnicianRepository _technicianRepo;

        public AppointmentService(IAppointmentRepository appointmentRepo, ITechnicianRepository technicianRepo)
        {
            _appointmentRepo = appointmentRepo;
            _technicianRepo = technicianRepo;
        }

        public async Task<Appointment> CreateAndAutoAssignAsync(DateTime scheduledTime, string description, string skillRequired)
        {
            // Create new appointment
            var appointment = new Appointment
            {
                ScheduledTime = scheduledTime,
                Description = description,
                Status = "Pending"
            };
            await _appointmentRepo.SaveAsync(appointment);

            // Find available technicians with the required skill
            var availableTechs = await _technicianRepo.GetAvailableTechniciansAsync(skillRequired);

            if (availableTechs != null && availableTechs.Any())
            {
                // Choose the first technician that meets the criteria
                var chosenTech = availableTechs.First();

                appointment.TechnicianId = chosenTech.TechnicianId;
                appointment.Status = "Assigned";

                await _appointmentRepo.UpdateAsync(appointment);
            }
            else
            {
                // No available technicians, notify admin
                appointment.Status = "WaitingForAdmin";
                await _appointmentRepo.UpdateAsync(appointment);
            }

            return appointment;
        }
    }
}
