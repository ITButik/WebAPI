using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITButikAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace ITButikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            List<Employee> employees = new List<Employee>();
            using (var db = new ITButikDBContext())
            {
                employees = db.Employee.ToList();
            }
            return Ok(employees);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Employee employee = new Employee();
            using (var db = new ITButikDBContext())
            {
                employee = db.Employee.Where(b => b.Id == id).ToList().FirstOrDefault();
            }
            return Ok(employee);
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
