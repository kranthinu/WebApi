using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DataModel
{
    public class Payments
    {
        public int ID { get; set; }
        public int StudentsID { get; set; }
        public int AmountDue { get; set; }
    }
}
