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
    public class UsersController : ControllerBase
    {
        private Test2021Context _testContext;

        public UsersController(Test2021Context testContext)
        {
            _testContext = testContext;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _testContext.TBL_USERS;
        }
        [HttpGet("{uname}")]
        public UserModel Get(string uname)
        {
            return _testContext.TBL_USERS.FirstOrDefault(s => s.USER_NAME == uname);
        }
    }
}
