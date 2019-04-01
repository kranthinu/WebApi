using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataModel;

namespace WebApi.DAL
{
    public interface IStudentsDAL
    {
        List<Students> getAllStudentsInfo();
        Students getStudentsInfo(int id);
        List<Students> insertStudentsInfo(Students student);
        List<Students> deleteStudentsInfo(int id);
    }
}
