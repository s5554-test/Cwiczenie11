﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenie11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenie11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        private readonly DoctorsDbContext _context;

        public DoctorsController(DoctorsDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctors);
        }
    }
}
