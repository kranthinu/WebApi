using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataModel;

namespace WebApi.DAL
{
    public class PaymentsDAL
    {
        public int ShowBalanceAmount(int id)
        {
            var balance = this.AllPayments().Where(x => x.StudentsID == id).Select(x => x.AmountDue).SingleOrDefault();

            if (balance != null)
                return balance;
            else
                throw new Exception("Invalid id to pass");
        }

        private List<Payments> AllPayments()
        {

            var payments = new List<Payments>();
            payments.Add(new Payments() { ID = 1, StudentsID = 2, AmountDue = 2500});
            payments.Add(new Payments() { ID = 2, StudentsID = 1, AmountDue = 3000});
            payments.Add(new Payments() { ID = 3, StudentsID = 4, AmountDue = 2000});
            payments.Add(new Payments() { ID = 4, StudentsID = 3, AmountDue = 1000});

            return payments;
        }
    }
}
