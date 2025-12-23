using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceManagement.Domain.Models
{
    public class Attandance
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public DateTime date { get; set; }
        public bool isPresent { get; set; }
    }
}
