using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretApi.Controllers
{
    [Route("api/[controller]")]
    // ^^ Syntactic sugar to replce: [Route("api/secret")] ? ^^
    public class SecretController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return SecretGet();
        }

        public string SecretGet()
        {
            return "This is the secret API";
        }
    }
}
