using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.BLL
{
    public interface IPaymentsBLL
    {
        int ShowBalanceAmount(int id);
    }
}
