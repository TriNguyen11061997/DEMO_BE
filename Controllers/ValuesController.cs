﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEMO_2.Data;
using DEMO_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DEMO_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
         private readonly EmployeeContext _context;

         public ValuesController(EmployeeContext context){
             _context =context;
         }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return  _context.Employees.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
