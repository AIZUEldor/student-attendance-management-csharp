using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAttendanceManagement.Domain.Models;
using StudentAttendanceManagement.Infrastructure;

namespace StudentAttendanceManagement.Application.Servises
{
    public class AttendanceService
    {
        private readonly AttendanceRepository _attendanceRepository = new AttendanceRepository();

        public void Add(Attandance attandance)
        {
            _attendanceRepository.Add(attandance);
        }

        public List<Attandance> GetAll()
        {
            return _attendanceRepository.GetAll();
        }
    }
}
