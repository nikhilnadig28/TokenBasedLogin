﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginFunction.Controllers
{
    [Authorize(Roles="Admin")]
    public class EmployeesController : ApiController
    {
        //public IEnumerable<TBL_EMPLOYEES> Get()
        //{
        //    using (dbNEVSEntities entities = new dbNEVSEntities())
        //    {
        //        return entities.TBL_EMPLOYEES.ToList();
        //    }
        //}
    }
}
