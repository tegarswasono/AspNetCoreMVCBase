using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCBase.Controllers.ThirdParty.QRCoder
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnQRCoderController : ControllerBase
    {
        public LearnQRCoderController() { } 
        public IActionResult Index()
        {
            return Ok("oke bro");
        }
    }
}
