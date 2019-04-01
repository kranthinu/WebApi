using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataModel;

namespace WebApi.DAL
{
    public interface IPaymentsDAL
    {
        int ShowBalanceAmount(int id);
    }
}
