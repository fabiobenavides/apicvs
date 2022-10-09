using Microsoft.AspNetCore.Mvc;

namespace APICVS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiCvsProccessor : ControllerBase
    {
        public apiCvsProccessor()
        {
        }

        [HttpGet(Name = "apicvsproccessor")]
        public string Get()
        {

        }
    }
}