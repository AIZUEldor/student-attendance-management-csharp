using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceManagement.Domain.Models
{
    public class ExternalAttendance
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public DateTime uploadedDate { get; set; }
        public string externalSystemName { get; set; }
    }
}
