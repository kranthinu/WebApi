using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DAL;
using WebApi.DataModel;

namespace WebApi.BLL
{
    public class StudentsBLL : IStudentsBLL
    {
        readonly IStudentsDAL studentsDAL;

        public StudentsBLL(IStudentsDAL _studentsDAL)
        {
            this.studentsDAL = _studentsDAL;
        }

        public List<Students> getAllStudentsInfo()
        {
            return this.studentsDAL.getAllStudentsInfo();
        }

        public Students getAllStudentsInfo(int id)
        {
            return this.studentsDAL.getStudentsInfo(id);
        }

        public List<Students> insertStudentsInfo(Students student)
        {
            return this.studentsDAL.insertStudentsInfo(student);
        }

        public List<Students> deleteStudentsInfo(int id)
        {
            return this.studentsDAL.deleteStudentsInfo(id);
        }
    }
}
