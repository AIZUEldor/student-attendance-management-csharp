using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAttendanceManagement.Domain.Models;
using StudentAttendanceManagement.Infrastructure;

namespace StudentAttendanceManagement.Application.Servises
{
    public class StudentServise
    {
        private readonly StudentRepsitory _studentRepsitory = new StudentRepsitory();

        public void Add(Student student)
        {
            _studentRepsitory.Add(student);
        }

        public List<Student> GetAll()
        {
            return _studentRepsitory.GetAll();
        }
    }
}
