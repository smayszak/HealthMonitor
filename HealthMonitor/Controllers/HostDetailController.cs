using System;
using Microsoft.AspNetCore.Mvc;

namespace HealthMonitor.Controllers
{
    [Route("api/[controller]")]
    public class HostDetailController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var result = new JsonResult(

                    new
                    {
                        HostName = Environment.MachineName,
                        IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                    }
                );
            return result;
        }
    }
}
