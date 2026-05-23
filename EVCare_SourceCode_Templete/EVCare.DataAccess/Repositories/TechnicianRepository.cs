using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVCare.DataAccess.Data;

namespace EVCare.DataAccess.Repositories
{
    public class TechnicianRepository : ITechnicianRepository
    {
        public async Task<List<Technician>> GetAvailableTechniciansAsync(string skill)
        {
            // Simulate a database query to find available technicians
            return await Task.FromResult(new List<Technician>
            {
                new Technician { TechnicianId = "TECH-001", FullName = "Negav", SkillCategory = skill, CurrentStatus = "Active" }
            });
        }
    }
}
