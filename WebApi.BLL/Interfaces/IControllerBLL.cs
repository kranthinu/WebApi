using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataModel;

namespace WebApi.BLL
{
    public interface IControllerBLL
    {
        List<Students> getAllStudentsInfo();

        Students getAllStudentsInfo(int id);

        List<Students> insertStudentsInfo(Students student);

        List<Students> deleteStudentsInfo(int id);

        int ShowBalanceAmount(int id);
    }
}
