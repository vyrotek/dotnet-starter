using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starter.API.V1
{
    [Route("v1/[controller]")]
    public abstract class APIController : Controller
    {
    }
}
