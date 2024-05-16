using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIinWebForms.Controllers
{
    public class MyEmployeesController : ApiController
    {
       public IHttpActionResult getempnames()
        {
            TestEntities ent= new TestEntities();
            var empnames=ent.TestTables.ToList();
            return Ok(empnames);
        }
    }
}
