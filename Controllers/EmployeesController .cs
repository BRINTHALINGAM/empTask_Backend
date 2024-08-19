using empTask.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace empTask.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeesController : ControllerBase
        {
            // Sample data
            private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Brintha S", Department = "Engineering", TotalTimeWorked = 120 },
            new Employee { Id = 2, Name = "Mark Willson", Department = "Marketing", TotalTimeWorked = 95 },
            new Employee { Id = 3, Name = "Selvi Muthu", Department = "HR", TotalTimeWorked = 80 }
        };

            // GET api/employees
            [HttpGet]
            public ActionResult<IEnumerable<Employee>> GetEmployees()
            {
                var sortedEmployees = Employees.OrderByDescending(e => e.TotalTimeWorked).ToList();
                return Ok(sortedEmployees);
            }
        }
    }

