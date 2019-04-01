using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataModel;

namespace WebApi.BLL
{
    public class ControllerBLL : IControllerBLL
    {
        private readonly IStudentsBLL studentsBLL;
        private readonly IPaymentsBLL paymentsBLL;

        public ControllerBLL(IStudentsBLL _studentsBLL, IPaymentsBLL _paymentsBLL)
        {
            this.studentsBLL = _studentsBLL;
            this.paymentsBLL = _paymentsBLL;
        }


        public List<Students> getAllStudentsInfo()
        {
            return this.studentsBLL.getAllStudentsInfo();
        }

        public Students getAllStudentsInfo(int id)
        {
            return this.studentsBLL.getAllStudentsInfo(id);
        }

        public List<Students> insertStudentsInfo(Students student)
        {
            return this.studentsBLL.insertStudentsInfo(student);
        }

        public List<Students> deleteStudentsInfo(int id)
        {
            return this.studentsBLL.deleteStudentsInfo(id);
        }

        public int ShowBalanceAmount(int id)
        {
            return this.paymentsBLL.ShowBalanceAmount(id);
        }
    }
}
