using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataModel;

namespace WebApi.DAL
{
    public class StudentsDAL
    {
        public List<Students> getAllStudentsInfo()
        {
            var students = new List<Students>();
            students.Add(new Students() { ID = 1, FirstName = "Alan", LastName = "Donald", Age = 20, Email = "Alan.Donald@gmail.com" });
            students.Add(new Students() { ID = 2, FirstName = "Stephen", LastName = "Miller", Age = 22, Email = "Stephen.Miller@gmail.com" });
            students.Add(new Students() { ID = 3, FirstName = "Ben", LastName = "Stokes", Age = 24, Email = "Ben.Stokes@gmail.com" });
            students.Add(new Students() { ID = 4, FirstName = "Brett", LastName = "Lee", Age = 26, Email = "Brett.Lee@gmail.com" });

            return students;
        }

        public Students getStudentsInfo(int id)
        {
            var student = this.getAllStudentsInfo().Where(x => x.ID == id).Select(x => x).SingleOrDefault();

            if (student != null)
                return student;
            else
                throw new Exception(string.Format("Invalid Id {0}", id));
        }

        public List<Students> insertStudentsInfo(Students student)
        {
            var students = this.getAllStudentsInfo();
            students.Add(student);

            return students;
        }

        public List<Students> deleteStudentsInfo(int id)
        {
            var students = this.getAllStudentsInfo();
            students.RemoveAt(id);

            return students;
        }
    }
}
