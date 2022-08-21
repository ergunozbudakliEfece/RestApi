using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Contexts;
using RestApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private Test2021Context _testContext;

        public TicketController(Test2021Context testContext)
        {
            _testContext = testContext;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<TicketModel> Get()
        {
            return _testContext.TBL_TICKETS;
        }
        [HttpPost]
        public void Post([FromBody] TicketModel value)
        {
            _testContext.TBL_TICKETS.Add(value);
            _testContext.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TicketModel value)
        {
            var employee = _testContext.TBL_TICKETS.FirstOrDefault(s => s.TICKET_ID == id);
            if (employee != null)
            {
                _testContext.Entry<TicketModel>(employee).CurrentValues.SetValues(value);
                _testContext.SaveChanges();
            }
        }
    }
}
