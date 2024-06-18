using FirstDeployment.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstDeployment.Controllers
{
    public class EMPController : ApiController
    {
        mydatabaseEntities1 m = new mydatabaseEntities1();
        [HttpGet]
        [Route("api/EMP/getemps")]
        
        public IHttpActionResult getemps()
        { 
           
            var employees = (from n in m.Emp_Table
                                       select n).ToList();
            return Ok(employees);

        }
        [HttpPost]
        [Route("api/EMP/AddEmp")]
        public IHttpActionResult AddEmp([FromBody] Emp_Table s)

        {
            m.Emp_Table.Add(s);
            m.SaveChanges();    
            return Ok("Successfully added a Employee!");

        }
    }
}
