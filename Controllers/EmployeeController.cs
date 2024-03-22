using Employee_Management_System.Models;
using Employee_Management_System.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;

        }

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return employeeService.Get();
        }


        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(string id)
        {
            var employee = employeeService.Get(id);
            if (employee == null)
            {
                return NotFound($"employee with  Id = {id} Not Found");
            }
            return employee;
        }



        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {

           
            employeeService.Create(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public  ActionResult Put(string id, [FromBody] Employee employee)
        {
            var exitingeEmployees =  employeeService.Get(id);
           
           
          if(exitingeEmployees == null)
            {
                return NotFound();
            }
          employeeService.Update(id, employee);
            return NoContent();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
