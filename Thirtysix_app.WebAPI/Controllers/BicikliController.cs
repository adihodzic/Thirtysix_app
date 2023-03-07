using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thirtysix_app.Model.Requests;
using Thirtysix_app.WebAPI.Services;

namespace Thirtysix_app.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicikliController : ControllerBase
    {
        private readonly IBicikliService _service;

        public BicikliController(IBicikliService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Bicikli>Get([FromQuery]BicikliSearchRequest search)
        {
            return _service.Get(search);
        }
    }
}
