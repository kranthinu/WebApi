﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.BLL;
using WebApi.DataModel;

namespace WebApi.Controllers
{
    public class StudentsController : ApiController
    {
        readonly IControllerBLL controllerBLL;
        public StudentsController(IControllerBLL _controllerBLL)
        {
            this.controllerBLL = _controllerBLL;
        }

        // GET api/<controller>
        public List<Students> Get()
        {
            return this.controllerBLL.getAllStudentsInfo();
        }

        // GET api/<controller>/5
        public Students Get(int id)
        {
            return this.controllerBLL.getAllStudentsInfo(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [RequireHttpsAttribute]
        public void Delete(int id)
        {
            this.controllerBLL.deleteStudentsInfo(id);
        }
    }
}