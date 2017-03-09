using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HealthMonitor.Controllers
{
    [Route("api/[controller]")]
    public class HostStatusController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "alive";
        }
    }
}
