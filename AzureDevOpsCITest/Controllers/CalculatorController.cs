using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AzureDevOpsCITest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public IActionResult Add([FromHeader] int n1, [FromHeader] int n2)
        {
            try
            {
                CalcService calcService = new CalcService();
                int result = calcService.Add(n1, n2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
