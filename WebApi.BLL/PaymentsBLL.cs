using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DAL;

namespace WebApi.BLL
{
    public class PaymentsBLL : IPaymentsBLL
    {
        readonly IPaymentsDAL paymentsDAL;

        public PaymentsBLL(IPaymentsDAL _paymentsDAL)
        {
            this.paymentsDAL = _paymentsDAL;
        }

        public int ShowBalanceAmount(int id)
        {
            return this.paymentsDAL.ShowBalanceAmount(id);
        }
    }
}
