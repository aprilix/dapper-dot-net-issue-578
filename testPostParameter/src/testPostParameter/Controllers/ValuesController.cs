﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testPostParameter.Models;

namespace testPostParameter.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
      
        // POST api/values
        [HttpPost]
        public void Post([FromBody]PropModel value)
        {
        }

    }
}
