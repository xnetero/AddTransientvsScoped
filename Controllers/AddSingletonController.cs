using AddTransientvsScoped.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddTransientvsScoped.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class AddSingletonController : ControllerBase
    {


      

        private readonly IAddSingletonService _singletonOperation1;
        private readonly IAddSingletonService _singletonOperation2;

        public AddSingletonController(IAddSingletonService singletonOperation1,
            IAddSingletonService singletonOperation2)
        {
            _singletonOperation1 = singletonOperation1;
            _singletonOperation2 = singletonOperation2;
        }



        [HttpGet(Name = "AddSingletonEndpoint")]
        public IActionResult GetOperations()
        {
            var response = new
            {
                Transient1 = _singletonOperation1.OperationId,
                Transient2 = _singletonOperation2.OperationId,
            };
            return Ok(response);
        }
    }
}
