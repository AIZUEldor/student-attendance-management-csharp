using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAttendanceManagement.Domain.Models;

namespace StudentAttendanceManagement.Infrastructure
{
    public class AttendanceRepository
    {
        private List<Attandance> attandances = new List<Attandance>();
        public void Add(Attandance attandance)
        {
            attandances.Add(attandance);
        }
        public List<Attandance> GetAll()
        {
            return attandances;
        }
    }
}
