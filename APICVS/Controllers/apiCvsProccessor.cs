using BL.BL;
using Microsoft.AspNetCore.Mvc;

namespace APICVS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiCvsProccessor : ControllerBase
    {
        private readonly IProccessor _proccessor;
        public apiCvsProccessor(/*IProccessor proccessor*/)
        {
            //Todo: Inversion of Control
            //_proccessor = proccessor;
            _proccessor = new Proccessor();
        }

        [HttpGet(Name = "apicvsproccessor")]
        public string Get(string cvsContent)
        {
            return _proccessor.Process(cvsContent);
        }
    }
}