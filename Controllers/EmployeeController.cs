using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using customerEmployeeManagementBackend.Domain;

namespace customerEmployeeManagementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET api/employee/{id}
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee e = new Employee(PersonType.Employee)
            {
                Id = id, 
                FirstName = "Mo Employee",
                LastName = "Afolayan",
                Address = "Rocksville",
                City = "Awesome City",
                State = "FL",
                Zip = "10000",
            };

            return Ok(e);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
