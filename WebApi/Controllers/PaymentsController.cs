using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.BLL;

namespace WebApi.Controllers
{
    [RequireHttpsAttribute]
    public class PaymentsController : ApiController
    {
        readonly IControllerBLL controllerBLL;
        public PaymentsController(IControllerBLL _controllerBLL)
        {
            this.controllerBLL = _controllerBLL;
        }


        // GET api/<controller>
        public string Get()
        {
            return "Pass a valid student Id";
        }

        // GET api/<controller>/5
        public int Get(int id)
        {
            return this.controllerBLL.ShowBalanceAmount(id);
        }
    }
}